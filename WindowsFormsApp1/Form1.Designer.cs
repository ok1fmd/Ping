namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIpPing = new System.Windows.Forms.TextBox();
            this.txtLogIp = new System.Windows.Forms.TextBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.lnbTestIp = new System.Windows.Forms.Label();
            this.btnStartTestIp = new System.Windows.Forms.Button();
            this.btnStopTestIp = new System.Windows.Forms.Button();
            this.txtIpPing1 = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPing1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbIp1 = new System.Windows.Forms.RadioButton();
            this.rdbIp2 = new System.Windows.Forms.RadioButton();
            this.rdbIp1Ip2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtIpPing
            // 
            this.txtIpPing.Location = new System.Drawing.Point(419, 55);
            this.txtIpPing.Name = "txtIpPing";
            this.txtIpPing.Size = new System.Drawing.Size(152, 20);
            this.txtIpPing.TabIndex = 0;
            this.txtIpPing.Text = "10.40.127.1";
            // 
            // txtLogIp
            // 
            this.txtLogIp.Location = new System.Drawing.Point(12, 26);
            this.txtLogIp.Multiline = true;
            this.txtLogIp.Name = "txtLogIp";
            this.txtLogIp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogIp.Size = new System.Drawing.Size(392, 275);
            this.txtLogIp.TabIndex = 1;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(587, 52);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping 1";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // lnbTestIp
            // 
            this.lnbTestIp.AutoSize = true;
            this.lnbTestIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lnbTestIp.Location = new System.Drawing.Point(422, 300);
            this.lnbTestIp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnbTestIp.Name = "lnbTestIp";
            this.lnbTestIp.Size = new System.Drawing.Size(91, 20);
            this.lnbTestIp.TabIndex = 39;
            this.lnbTestIp.Text = "Stav testu";
            // 
            // btnStartTestIp
            // 
            this.btnStartTestIp.Location = new System.Drawing.Point(587, 278);
            this.btnStartTestIp.Name = "btnStartTestIp";
            this.btnStartTestIp.Size = new System.Drawing.Size(75, 23);
            this.btnStartTestIp.TabIndex = 40;
            this.btnStartTestIp.Text = "Start";
            this.btnStartTestIp.UseVisualStyleBackColor = true;
            this.btnStartTestIp.Click += new System.EventHandler(this.btnStartTestIp_Click);
            // 
            // btnStopTestIp
            // 
            this.btnStopTestIp.Location = new System.Drawing.Point(587, 318);
            this.btnStopTestIp.Name = "btnStopTestIp";
            this.btnStopTestIp.Size = new System.Drawing.Size(75, 23);
            this.btnStopTestIp.TabIndex = 41;
            this.btnStopTestIp.Text = "Stop";
            this.btnStopTestIp.UseVisualStyleBackColor = true;
            this.btnStopTestIp.Click += new System.EventHandler(this.btnStopTestIp_Click);
            // 
            // txtIpPing1
            // 
            this.txtIpPing1.Location = new System.Drawing.Point(419, 120);
            this.txtIpPing1.Name = "txtIpPing1";
            this.txtIpPing1.Size = new System.Drawing.Size(152, 20);
            this.txtIpPing1.TabIndex = 44;
            this.txtIpPing1.Text = "10.40.127.1";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(495, 229);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(76, 20);
            this.txtTim.TabIndex = 45;
            this.txtTim.Text = "120";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Timeout";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(587, 227);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 47;
            this.btnTim.Text = "Timeout";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 20);
            this.textBox2.TabIndex = 48;
            this.textBox2.Text = "77.75.79.222;46.255.231.129";
            // 
            // btnPing1
            // 
            this.btnPing1.Location = new System.Drawing.Point(587, 117);
            this.btnPing1.Name = "btnPing1";
            this.btnPing1.Size = new System.Drawing.Size(75, 23);
            this.btnPing1.TabIndex = 49;
            this.btnPing1.Text = "Ping 2";
            this.btnPing1.UseVisualStyleBackColor = true;
            this.btnPing1.Click += new System.EventHandler(this.btnPing1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Pozn.";
            // 
            // rdbIp1
            // 
            this.rdbIp1.AutoSize = true;
            this.rdbIp1.Location = new System.Drawing.Point(419, 32);
            this.rdbIp1.Name = "rdbIp1";
            this.rdbIp1.Size = new System.Drawing.Size(44, 17);
            this.rdbIp1.TabIndex = 54;
            this.rdbIp1.TabStop = true;
            this.rdbIp1.Text = "IP 1";
            this.rdbIp1.UseVisualStyleBackColor = true;
            // 
            // rdbIp2
            // 
            this.rdbIp2.AutoSize = true;
            this.rdbIp2.Location = new System.Drawing.Point(419, 97);
            this.rdbIp2.Name = "rdbIp2";
            this.rdbIp2.Size = new System.Drawing.Size(44, 17);
            this.rdbIp2.TabIndex = 55;
            this.rdbIp2.TabStop = true;
            this.rdbIp2.Text = "IP 2";
            this.rdbIp2.UseVisualStyleBackColor = true;
            // 
            // rdbIp1Ip2
            // 
            this.rdbIp1Ip2.AutoSize = true;
            this.rdbIp1Ip2.Location = new System.Drawing.Point(419, 161);
            this.rdbIp1Ip2.Name = "rdbIp1Ip2";
            this.rdbIp1Ip2.Size = new System.Drawing.Size(66, 17);
            this.rdbIp1Ip2.TabIndex = 56;
            this.rdbIp1Ip2.TabStop = true;
            this.rdbIp1Ip2.Text = "IP 1 IP 2";
            this.rdbIp1Ip2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 372);
            this.Controls.Add(this.rdbIp1Ip2);
            this.Controls.Add(this.rdbIp2);
            this.Controls.Add(this.rdbIp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPing1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtIpPing1);
            this.Controls.Add(this.btnStopTestIp);
            this.Controls.Add(this.btnStartTestIp);
            this.Controls.Add(this.lnbTestIp);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.txtLogIp);
            this.Controls.Add(this.txtIpPing);
            this.Name = "Form1";
            this.Text = "Test Ping";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIpPing;
        private System.Windows.Forms.TextBox txtLogIp;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label lnbTestIp;
        private System.Windows.Forms.Button btnStartTestIp;
        private System.Windows.Forms.Button btnStopTestIp;
        private System.Windows.Forms.TextBox txtIpPing1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPing1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbIp1;
        private System.Windows.Forms.RadioButton rdbIp2;
        private System.Windows.Forms.RadioButton rdbIp1Ip2;
    }
}

