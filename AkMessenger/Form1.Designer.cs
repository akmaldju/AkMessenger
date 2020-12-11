namespace AkMessenger
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPortLocal = new System.Windows.Forms.TextBox();
            this.txtIpLocal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.connPan = new System.Windows.Forms.Panel();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.txtIpClient = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.lstChat = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlTop2 = new System.Windows.Forms.Panel();
            this.connPan2 = new System.Windows.Forms.Panel();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtIpClient2 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlTop2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPortLocal);
            this.groupBox1.Controls.Add(this.txtIpLocal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your info:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 22);
            this.txtName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(125, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP:";
            // 
            // txtPortLocal
            // 
            this.txtPortLocal.Location = new System.Drawing.Point(11, 128);
            this.txtPortLocal.Name = "txtPortLocal";
            this.txtPortLocal.ReadOnly = true;
            this.txtPortLocal.Size = new System.Drawing.Size(189, 22);
            this.txtPortLocal.TabIndex = 1;
            this.txtPortLocal.Text = "8842";
            this.txtPortLocal.TextChanged += new System.EventHandler(this.txtPortLocal_TextChanged);
            this.txtPortLocal.DoubleClick += new System.EventHandler(this.txtPortLocal_DoubleClick);
            // 
            // txtIpLocal
            // 
            this.txtIpLocal.Location = new System.Drawing.Point(11, 83);
            this.txtIpLocal.Name = "txtIpLocal";
            this.txtIpLocal.Size = new System.Drawing.Size(189, 22);
            this.txtIpLocal.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox2.Controls.Add(this.connPan);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPortClient);
            this.groupBox2.Controls.Add(this.txtIpClient);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(210, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Partner info:";
            // 
            // connPan
            // 
            this.connPan.BackColor = System.Drawing.Color.Red;
            this.connPan.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.connPan.Location = new System.Drawing.Point(173, 14);
            this.connPan.Name = "connPan";
            this.connPan.Size = new System.Drawing.Size(22, 21);
            this.connPan.TabIndex = 8;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(123, 111);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP:";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Location = new System.Drawing.Point(6, 83);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.ReadOnly = true;
            this.txtPortClient.Size = new System.Drawing.Size(189, 22);
            this.txtPortClient.TabIndex = 3;
            this.txtPortClient.Text = "8842";
            this.txtPortClient.TextChanged += new System.EventHandler(this.txtPortClient_TextChanged);
            this.txtPortClient.DoubleClick += new System.EventHandler(this.txtPortClient_DoubleClick);
            // 
            // txtIpClient
            // 
            this.txtIpClient.Location = new System.Drawing.Point(6, 38);
            this.txtIpClient.Name = "txtIpClient";
            this.txtIpClient.Size = new System.Drawing.Size(189, 22);
            this.txtIpClient.TabIndex = 2;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(3, 8);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(312, 22);
            this.txtMessage.TabIndex = 3;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(337, 8);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // lstChat
            // 
            this.lstChat.BackColor = System.Drawing.Color.Honeydew;
            this.lstChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstChat.ForeColor = System.Drawing.Color.ForestGreen;
            this.lstChat.Location = new System.Drawing.Point(0, 0);
            this.lstChat.Name = "lstChat";
            this.lstChat.ReadOnly = true;
            this.lstChat.Size = new System.Drawing.Size(425, 491);
            this.lstChat.TabIndex = 5;
            this.lstChat.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 182);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.lstChat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 491);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.Controls.Add(this.txtMessage);
            this.panel3.Controls.Add(this.btnSend);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 673);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 36);
            this.panel3.TabIndex = 7;
            // 
            // pnlTop2
            // 
            this.pnlTop2.BackColor = System.Drawing.Color.Teal;
            this.pnlTop2.Controls.Add(this.panel6);
            this.pnlTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop2.Location = new System.Drawing.Point(0, 182);
            this.pnlTop2.Name = "pnlTop2";
            this.pnlTop2.Size = new System.Drawing.Size(425, 33);
            this.pnlTop2.TabIndex = 6;
            this.pnlTop2.Visible = false;
            this.pnlTop2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlTop2_MouseClick);
            // 
            // connPan2
            // 
            this.connPan2.BackColor = System.Drawing.Color.Chartreuse;
            this.connPan2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.connPan2.Location = new System.Drawing.Point(383, 7);
            this.connPan2.Name = "connPan2";
            this.connPan2.Size = new System.Drawing.Size(22, 21);
            this.connPan2.TabIndex = 9;
            // 
            // txtName2
            // 
            this.txtName2.BackColor = System.Drawing.Color.Honeydew;
            this.txtName2.Location = new System.Drawing.Point(11, 6);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(189, 22);
            this.txtName2.TabIndex = 11;
            // 
            // txtIpClient2
            // 
            this.txtIpClient2.BackColor = System.Drawing.Color.Honeydew;
            this.txtIpClient2.Location = new System.Drawing.Point(216, 6);
            this.txtIpClient2.Name = "txtIpClient2";
            this.txtIpClient2.Size = new System.Drawing.Size(136, 22);
            this.txtIpClient2.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel6.Controls.Add(this.txtIpClient2);
            this.panel6.Controls.Add(this.connPan2);
            this.panel6.Controls.Add(this.txtName2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(408, 33);
            this.panel6.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(425, 709);
            this.Controls.Add(this.pnlTop2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger 1.0 by Akmal Djumakhodjaev";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlTop2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPortLocal;
        private System.Windows.Forms.TextBox txtIpLocal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.TextBox txtIpClient;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnStart;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.RichTextBox lstChat;
        private System.Windows.Forms.Panel connPan;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlTop2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIpClient2;
        private System.Windows.Forms.Panel connPan2;
        private System.Windows.Forms.TextBox txtName2;
    }
}

