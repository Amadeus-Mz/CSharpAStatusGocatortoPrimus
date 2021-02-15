
namespace CheckGocator
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
            this.tbipGo = new System.Windows.Forms.TextBox();
            this.tbportGo = new System.Windows.Forms.TextBox();
            this.btnConnectGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbportMod = new System.Windows.Forms.TextBox();
            this.tbipMod = new System.Windows.Forms.TextBox();
            this.btnConnectMod = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbipGo
            // 
            this.tbipGo.Location = new System.Drawing.Point(127, 53);
            this.tbipGo.Name = "tbipGo";
            this.tbipGo.Size = new System.Drawing.Size(151, 26);
            this.tbipGo.TabIndex = 0;
            this.tbipGo.Text = "192.168.1.11";
            // 
            // tbportGo
            // 
            this.tbportGo.Location = new System.Drawing.Point(127, 99);
            this.tbportGo.Name = "tbportGo";
            this.tbportGo.Size = new System.Drawing.Size(151, 26);
            this.tbportGo.TabIndex = 1;
            this.tbportGo.Text = "8190";
            // 
            // btnConnectGo
            // 
            this.btnConnectGo.Location = new System.Drawing.Point(321, 62);
            this.btnConnectGo.Name = "btnConnectGo";
            this.btnConnectGo.Size = new System.Drawing.Size(120, 60);
            this.btnConnectGo.TabIndex = 2;
            this.btnConnectGo.Text = "Connect";
            this.btnConnectGo.UseVisualStyleBackColor = true;
            this.btnConnectGo.Click += new System.EventHandler(this.btnConnectGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Gocator :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port :";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(137, 288);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 60);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnectGo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sensor_Stage";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(277, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 60);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "IP Primus :";
            // 
            // tbportMod
            // 
            this.tbportMod.Location = new System.Drawing.Point(127, 221);
            this.tbportMod.Name = "tbportMod";
            this.tbportMod.Size = new System.Drawing.Size(151, 26);
            this.tbportMod.TabIndex = 6;
            this.tbportMod.Text = "501";
            // 
            // tbipMod
            // 
            this.tbipMod.Location = new System.Drawing.Point(127, 175);
            this.tbipMod.Name = "tbipMod";
            this.tbipMod.Size = new System.Drawing.Size(151, 26);
            this.tbipMod.TabIndex = 5;
            this.tbipMod.Text = "192.168.1.10";
            // 
            // btnConnectMod
            // 
            this.btnConnectMod.Location = new System.Drawing.Point(321, 178);
            this.btnConnectMod.Name = "btnConnectMod";
            this.btnConnectMod.Size = new System.Drawing.Size(120, 60);
            this.btnConnectMod.TabIndex = 9;
            this.btnConnectMod.Text = "Connect";
            this.btnConnectMod.UseVisualStyleBackColor = true;
            this.btnConnectMod.Click += new System.EventHandler(this.btnConnectMod_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 386);
            this.Controls.Add(this.btnConnectMod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbportMod);
            this.Controls.Add(this.tbipMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnConnectGo);
            this.Controls.Add(this.tbportGo);
            this.Controls.Add(this.tbipGo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gocator to Primus (Check Status)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbipGo;
        private System.Windows.Forms.TextBox tbportGo;
        private System.Windows.Forms.Button btnConnectGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbportMod;
        private System.Windows.Forms.TextBox tbipMod;
        private System.Windows.Forms.Button btnConnectMod;
    }
}

