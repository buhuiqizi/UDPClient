using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;


/* UDP协议
 * 发送步骤:绑定一个端点，然后向目标端点发送消息
 * 接受步骤:绑定一个端点，然后就开始接受，不能指定发送方。传入一个额外的返回值(用rel实现的)，获取发送方端点
 * 接受方要一直处于激活状态，要不然信息会直接丢失
 */




namespace UDPClient
{
    public partial class Form1 : Form
    {
        private UdpClient sendUdpClient;
        private UdpClient receiveUdpClient;

        public Form1()
        {
            InitializeComponent();
            IPAddress[] ips = Dns.GetHostAddresses("");
            t_OwnIp.Text = ips[3].ToString();
            int port = 51833;
            t_OwnDuan.Text = port.ToString();
            t_GoalIp.Text = ips[3].ToString();
            t_GoalDuan.Text = port.ToString();
        }

        //发送消息
        private void b_Send_Click(object sender, EventArgs e)
        {
            if(t_SendMessage.Text==string.Empty)
            {
                MessageBox.Show("发送内容不能为空","提示");
                return;
            }

            //选择发送模式
            if(c_IsNiMing.Checked==true)
            {
                //匿名模式(套接字绑定的端口由系统随机分配)
                sendUdpClient = new UdpClient(0);
            }
            else
            {
                //实名模式(套接字绑定到本地指定的端口)
                IPAddress localIp = IPAddress.Parse(t_OwnIp.Text);
                IPEndPoint localIpEndpoint = new IPEndPoint(localIp, int.Parse(t_OwnDuan.Text));
                sendUdpClient = new UdpClient(localIpEndpoint);
            }

            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(t_SendMessage.Text);
        }

        //发送消息方法
        private void SendMessage(object obj)
        {
            String message = (String)obj;
            Byte[] sendbytes = Encoding.Unicode.GetBytes(message);
            IPAddress remoteIp = IPAddress.Parse(t_GoalIp.Text);
            IPEndPoint remotIpEndpoint = new IPEndPoint(remoteIp, int.Parse(t_GoalDuan.Text));
            sendUdpClient.Send(sendbytes, sendbytes.Length, remotIpEndpoint);

            sendUdpClient.Close();

            //清空发送消息框     !!!这里还存在疑问
            this.Invoke(new Action(() => t_SendMessage.Clear()));
        }

        //接受消息
        private void b_Receive_Click(object sender, EventArgs e)
        {
            //创建接受套接字
            IPAddress localIp = IPAddress.Parse(t_OwnIp.Text);
            IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(t_OwnDuan.Text));
            receiveUdpClient = new UdpClient(localIpEndPoint);

            Thread receiveThread = new Thread(receiveMessage);
            receiveThread.Start();
        }

        //接受消息方法
        private void receiveMessage()
        {
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while(true)
            {
                try
                {
                    //猜测:现在还不知道是谁发的消息，所以使用一个remoteIpEndPoind来存储消息来源
                    //rel即额外的返回值
                    byte[] receiveBytes = receiveUdpClient.Receive(ref remoteIpEndPoint);

                    String message = Encoding.Unicode.GetString(receiveBytes);

                    
                    this.Invoke(new Action(()=>
                        {
                            t_MessageBox.Text += remoteIpEndPoint.ToString();
                            t_MessageBox.Text += Environment.NewLine;
                            t_MessageBox.Text += message;
                            t_MessageBox.Text += Environment.NewLine;
                        }));
                }
                catch 
                {

                    break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiveUdpClient!=null)
            {
                receiveUdpClient.Close();
                receiveUdpClient.Dispose();
            }
        }

        private void b_Pause_Click(object sender, EventArgs e)
        {
            if (receiveUdpClient != null)
            {
                receiveUdpClient.Close();
                receiveUdpClient.Dispose();
            }
        }
    }
}
