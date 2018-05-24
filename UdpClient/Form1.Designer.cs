namespace UDPClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.l_OwnIp = new System.Windows.Forms.Label();
            this.l_GoalIp = new System.Windows.Forms.Label();
            this.t_OwnIp = new System.Windows.Forms.TextBox();
            this.t_GoalIp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_OwnDuan = new System.Windows.Forms.TextBox();
            this.t_GoalDuan = new System.Windows.Forms.TextBox();
            this.c_IsNiMing = new System.Windows.Forms.CheckBox();
            this.t_SendMessage = new System.Windows.Forms.TextBox();
            this.b_Send = new System.Windows.Forms.Button();
            this.t_MessageBox = new System.Windows.Forms.TextBox();
            this.b_Pause = new System.Windows.Forms.Button();
            this.b_Receive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_OwnIp
            // 
            this.l_OwnIp.AutoSize = true;
            this.l_OwnIp.Location = new System.Drawing.Point(12, 16);
            this.l_OwnIp.Name = "l_OwnIp";
            this.l_OwnIp.Size = new System.Drawing.Size(53, 15);
            this.l_OwnIp.TabIndex = 0;
            this.l_OwnIp.Text = "本机IP";
            // 
            // l_GoalIp
            // 
            this.l_GoalIp.AutoSize = true;
            this.l_GoalIp.Location = new System.Drawing.Point(12, 48);
            this.l_GoalIp.Name = "l_GoalIp";
            this.l_GoalIp.Size = new System.Drawing.Size(53, 15);
            this.l_GoalIp.TabIndex = 1;
            this.l_GoalIp.Text = "目标IP";
            // 
            // t_OwnIp
            // 
            this.t_OwnIp.Location = new System.Drawing.Point(71, 7);
            this.t_OwnIp.Name = "t_OwnIp";
            this.t_OwnIp.Size = new System.Drawing.Size(161, 25);
            this.t_OwnIp.TabIndex = 2;
            // 
            // t_GoalIp
            // 
            this.t_GoalIp.Location = new System.Drawing.Point(71, 41);
            this.t_GoalIp.Name = "t_GoalIp";
            this.t_GoalIp.Size = new System.Drawing.Size(161, 25);
            this.t_GoalIp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // t_OwnDuan
            // 
            this.t_OwnDuan.Location = new System.Drawing.Point(259, 6);
            this.t_OwnDuan.Name = "t_OwnDuan";
            this.t_OwnDuan.Size = new System.Drawing.Size(60, 25);
            this.t_OwnDuan.TabIndex = 6;
            // 
            // t_GoalDuan
            // 
            this.t_GoalDuan.Location = new System.Drawing.Point(259, 41);
            this.t_GoalDuan.Name = "t_GoalDuan";
            this.t_GoalDuan.Size = new System.Drawing.Size(60, 25);
            this.t_GoalDuan.TabIndex = 7;
            // 
            // c_IsNiMing
            // 
            this.c_IsNiMing.AutoSize = true;
            this.c_IsNiMing.Location = new System.Drawing.Point(12, 85);
            this.c_IsNiMing.Name = "c_IsNiMing";
            this.c_IsNiMing.Size = new System.Drawing.Size(59, 19);
            this.c_IsNiMing.TabIndex = 8;
            this.c_IsNiMing.Text = "匿名";
            this.c_IsNiMing.UseVisualStyleBackColor = true;
            // 
            // t_SendMessage
            // 
            this.t_SendMessage.Location = new System.Drawing.Point(71, 81);
            this.t_SendMessage.Name = "t_SendMessage";
            this.t_SendMessage.Size = new System.Drawing.Size(172, 25);
            this.t_SendMessage.TabIndex = 9;
            // 
            // b_Send
            // 
            this.b_Send.Location = new System.Drawing.Point(260, 81);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(59, 23);
            this.b_Send.TabIndex = 10;
            this.b_Send.Text = "发送";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.b_Send_Click);
            // 
            // t_MessageBox
            // 
            this.t_MessageBox.Location = new System.Drawing.Point(15, 128);
            this.t_MessageBox.Multiline = true;
            this.t_MessageBox.Name = "t_MessageBox";
            this.t_MessageBox.Size = new System.Drawing.Size(304, 245);
            this.t_MessageBox.TabIndex = 11;
            // 
            // b_Pause
            // 
            this.b_Pause.Location = new System.Drawing.Point(71, 380);
            this.b_Pause.Name = "b_Pause";
            this.b_Pause.Size = new System.Drawing.Size(75, 23);
            this.b_Pause.TabIndex = 12;
            this.b_Pause.Text = "停止";
            this.b_Pause.UseVisualStyleBackColor = true;
            this.b_Pause.Click += new System.EventHandler(this.b_Pause_Click);
            // 
            // b_Receive
            // 
            this.b_Receive.Location = new System.Drawing.Point(195, 380);
            this.b_Receive.Name = "b_Receive";
            this.b_Receive.Size = new System.Drawing.Size(75, 23);
            this.b_Receive.TabIndex = 13;
            this.b_Receive.Text = "接受";
            this.b_Receive.UseVisualStyleBackColor = true;
            this.b_Receive.Click += new System.EventHandler(this.b_Receive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.b_Receive);
            this.Controls.Add(this.b_Pause);
            this.Controls.Add(this.t_MessageBox);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.t_SendMessage);
            this.Controls.Add(this.c_IsNiMing);
            this.Controls.Add(this.t_GoalDuan);
            this.Controls.Add(this.t_OwnDuan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_GoalIp);
            this.Controls.Add(this.t_OwnIp);
            this.Controls.Add(this.l_GoalIp);
            this.Controls.Add(this.l_OwnIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_OwnIp;
        private System.Windows.Forms.Label l_GoalIp;
        private System.Windows.Forms.TextBox t_OwnIp;
        private System.Windows.Forms.TextBox t_GoalIp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_OwnDuan;
        private System.Windows.Forms.TextBox t_GoalDuan;
        private System.Windows.Forms.CheckBox c_IsNiMing;
        private System.Windows.Forms.TextBox t_SendMessage;
        private System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.TextBox t_MessageBox;
        private System.Windows.Forms.Button b_Pause;
        private System.Windows.Forms.Button b_Receive;
    }
}

