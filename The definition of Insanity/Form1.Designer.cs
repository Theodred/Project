namespace The_definition_of_Insanity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.label_Connect = new System.Windows.Forms.Label();
            this.tb_LocalIP = new System.Windows.Forms.TextBox();
            this.tb_LocalPort = new System.Windows.Forms.TextBox();
            this.tb_RemotePort = new System.Windows.Forms.TextBox();
            this.tb_RemoteIP = new System.Windows.Forms.TextBox();
            this.lb_Conversation = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_LocalPort);
            this.groupBox1.Controls.Add(this.tb_LocalIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_RemotePort);
            this.groupBox2.Controls.Add(this.tb_RemoteIP);
            this.groupBox2.Location = new System.Drawing.Point(435, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // rtb_Message
            // 
            this.rtb_Message.Location = new System.Drawing.Point(13, 370);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(512, 60);
            this.rtb_Message.TabIndex = 3;
            this.rtb_Message.Text = "";
            this.rtb_Message.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_Message_KeyPress);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(531, 370);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(104, 60);
            this.Send.TabIndex = 4;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // label_Connect
            // 
            this.label_Connect.AutoSize = true;
            this.label_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Connect.Location = new System.Drawing.Point(218, 40);
            this.label_Connect.Name = "label_Connect";
            this.label_Connect.Size = new System.Drawing.Size(211, 55);
            this.label_Connect.TabIndex = 5;
            this.label_Connect.Text = "Connect";
            this.label_Connect.Click += new System.EventHandler(this.label_Connect_Click);
            // 
            // tb_LocalIP
            // 
            this.tb_LocalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LocalIP.Location = new System.Drawing.Point(7, 20);
            this.tb_LocalIP.Name = "tb_LocalIP";
            this.tb_LocalIP.Size = new System.Drawing.Size(187, 31);
            this.tb_LocalIP.TabIndex = 0;
            // 
            // tb_LocalPort
            // 
            this.tb_LocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_LocalPort.Location = new System.Drawing.Point(7, 57);
            this.tb_LocalPort.Name = "tb_LocalPort";
            this.tb_LocalPort.Size = new System.Drawing.Size(187, 31);
            this.tb_LocalPort.TabIndex = 1;
            // 
            // tb_RemotePort
            // 
            this.tb_RemotePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RemotePort.Location = new System.Drawing.Point(6, 57);
            this.tb_RemotePort.Name = "tb_RemotePort";
            this.tb_RemotePort.Size = new System.Drawing.Size(187, 31);
            this.tb_RemotePort.TabIndex = 2;
            // 
            // tb_RemoteIP
            // 
            this.tb_RemoteIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_RemoteIP.Location = new System.Drawing.Point(6, 20);
            this.tb_RemoteIP.Name = "tb_RemoteIP";
            this.tb_RemoteIP.Size = new System.Drawing.Size(187, 31);
            this.tb_RemoteIP.TabIndex = 3;
            // 
            // lb_Conversation
            // 
            this.lb_Conversation.FormattingEnabled = true;
            this.lb_Conversation.Location = new System.Drawing.Point(13, 119);
            this.lb_Conversation.Name = "lb_Conversation";
            this.lb_Conversation.Size = new System.Drawing.Size(615, 238);
            this.lb_Conversation.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 442);
            this.Controls.Add(this.lb_Conversation);
            this.Controls.Add(this.label_Connect);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.rtb_Message);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_LocalPort;
        private System.Windows.Forms.TextBox tb_LocalIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_RemotePort;
        private System.Windows.Forms.TextBox tb_RemoteIP;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label label_Connect;
        private System.Windows.Forms.ListBox lb_Conversation;
    }
}

