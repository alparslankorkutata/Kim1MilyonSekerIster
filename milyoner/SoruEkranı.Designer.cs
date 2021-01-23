namespace Kim1MilyonSekerIster
{
    partial class frmSoruEkranı
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
            this.components = new System.ComponentModel.Container();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeyirci = new System.Windows.Forms.Button();
            this.btnCiftCevap = new System.Windows.Forms.Button();
            this.btnYuzde50 = new System.Windows.Forms.Button();
            this.btnTelefon = new System.Windows.Forms.Button();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.btnCekil = new System.Windows.Forms.Button();
            this.lblZaman = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.tmrZaman = new System.Windows.Forms.Timer(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.pbMilyoner = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMilyoner)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(81, 335);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(56, 25);
            this.lbl2.TabIndex = 46;
            this.lbl2.Text = "1000";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl3.ForeColor = System.Drawing.Color.Yellow;
            this.lbl3.Location = new System.Drawing.Point(81, 310);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(56, 25);
            this.lbl3.TabIndex = 47;
            this.lbl3.Text = "2000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeyirci);
            this.groupBox1.Controls.Add(this.btnCiftCevap);
            this.groupBox1.Controls.Add(this.btnYuzde50);
            this.groupBox1.Controls.Add(this.btnTelefon);
            this.groupBox1.Controls.Add(this.lbl12);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl11);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl10);
            this.groupBox1.Controls.Add(this.lbl5);
            this.groupBox1.Controls.Add(this.lbl9);
            this.groupBox1.Controls.Add(this.lbl6);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(519, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 388);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // btnSeyirci
            // 
            this.btnSeyirci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeyirci.Location = new System.Drawing.Point(74, 12);
            this.btnSeyirci.Name = "btnSeyirci";
            this.btnSeyirci.Size = new System.Drawing.Size(62, 32);
            this.btnSeyirci.TabIndex = 61;
            this.btnSeyirci.UseVisualStyleBackColor = true;
            this.btnSeyirci.Click += new System.EventHandler(this.btnSeyirci_Click);
            // 
            // btnCiftCevap
            // 
            this.btnCiftCevap.Enabled = false;
            this.btnCiftCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCiftCevap.Location = new System.Drawing.Point(74, 50);
            this.btnCiftCevap.Name = "btnCiftCevap";
            this.btnCiftCevap.Size = new System.Drawing.Size(62, 32);
            this.btnCiftCevap.TabIndex = 60;
            this.btnCiftCevap.Text = "2X";
            this.btnCiftCevap.UseVisualStyleBackColor = true;
            this.btnCiftCevap.Visible = false;
            this.btnCiftCevap.Click += new System.EventHandler(this.btnCiftCevap_Click);
            // 
            // btnYuzde50
            // 
            this.btnYuzde50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYuzde50.Location = new System.Drawing.Point(6, 50);
            this.btnYuzde50.Name = "btnYuzde50";
            this.btnYuzde50.Size = new System.Drawing.Size(62, 32);
            this.btnYuzde50.TabIndex = 59;
            this.btnYuzde50.UseVisualStyleBackColor = true;
            this.btnYuzde50.Click += new System.EventHandler(this.btnYuzde50_Click);
            // 
            // btnTelefon
            // 
            this.btnTelefon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTelefon.Location = new System.Drawing.Point(6, 12);
            this.btnTelefon.Name = "btnTelefon";
            this.btnTelefon.Size = new System.Drawing.Size(62, 32);
            this.btnTelefon.TabIndex = 58;
            this.btnTelefon.UseVisualStyleBackColor = true;
            this.btnTelefon.Click += new System.EventHandler(this.btnTelefon_Click);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl12.Location = new System.Drawing.Point(48, 85);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(89, 25);
            this.lbl12.TabIndex = 56;
            this.lbl12.Text = "1000000";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.ForeColor = System.Drawing.Color.Yellow;
            this.lbl1.Location = new System.Drawing.Point(92, 360);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(45, 25);
            this.lbl1.TabIndex = 57;
            this.lbl1.Text = "500";
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl11.ForeColor = System.Drawing.Color.Yellow;
            this.lbl11.Location = new System.Drawing.Point(59, 110);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(78, 25);
            this.lbl11.TabIndex = 55;
            this.lbl11.Text = "250000";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl4.ForeColor = System.Drawing.Color.Yellow;
            this.lbl4.Location = new System.Drawing.Point(81, 285);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(56, 25);
            this.lbl4.TabIndex = 48;
            this.lbl4.Text = "3000";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl10.ForeColor = System.Drawing.Color.Yellow;
            this.lbl10.Location = new System.Drawing.Point(59, 135);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(78, 25);
            this.lbl10.TabIndex = 54;
            this.lbl10.Text = "125000";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl5.ForeColor = System.Drawing.Color.Yellow;
            this.lbl5.Location = new System.Drawing.Point(81, 260);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(56, 25);
            this.lbl5.TabIndex = 49;
            this.lbl5.Text = "5000";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl9.ForeColor = System.Drawing.Color.Yellow;
            this.lbl9.Location = new System.Drawing.Point(70, 160);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(67, 25);
            this.lbl9.TabIndex = 53;
            this.lbl9.Text = "60000";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl6.ForeColor = System.Drawing.Color.Yellow;
            this.lbl6.Location = new System.Drawing.Point(81, 235);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(56, 25);
            this.lbl6.TabIndex = 50;
            this.lbl6.Text = "7500";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl8.ForeColor = System.Drawing.Color.Yellow;
            this.lbl8.Location = new System.Drawing.Point(70, 185);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(67, 25);
            this.lbl8.TabIndex = 52;
            this.lbl8.Text = "30000";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl7.Location = new System.Drawing.Point(70, 210);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(67, 25);
            this.lbl7.TabIndex = 51;
            this.lbl7.Text = "15000";
            // 
            // btnCekil
            // 
            this.btnCekil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCekil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCekil.ForeColor = System.Drawing.Color.Snow;
            this.btnCekil.Location = new System.Drawing.Point(12, 168);
            this.btnCekil.Name = "btnCekil";
            this.btnCekil.Size = new System.Drawing.Size(70, 36);
            this.btnCekil.TabIndex = 71;
            this.btnCekil.Text = "ÇEKİL";
            this.btnCekil.UseVisualStyleBackColor = false;
            this.btnCekil.Visible = false;
            this.btnCekil.Click += new System.EventHandler(this.btnCekil_Click);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.ForeColor = System.Drawing.Color.White;
            this.lblZaman.Location = new System.Drawing.Point(50, 58);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(0, 31);
            this.lblZaman.TabIndex = 70;
            // 
            // txtSoru
            // 
            this.txtSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtSoru.Location = new System.Drawing.Point(12, 236);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(501, 73);
            this.txtSoru.TabIndex = 67;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnExit.Location = new System.Drawing.Point(632, 22);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 23);
            this.btnExit.TabIndex = 66;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn4.Location = new System.Drawing.Point(267, 397);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(248, 41);
            this.btn4.TabIndex = 65;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn3.Location = new System.Drawing.Point(12, 397);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(248, 41);
            this.btn3.TabIndex = 64;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn2.Location = new System.Drawing.Point(267, 331);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(248, 41);
            this.btn2.TabIndex = 63;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // tmrZaman
            // 
            this.tmrZaman.Enabled = true;
            this.tmrZaman.Interval = 1000;
            this.tmrZaman.Tick += new System.EventHandler(this.tmrZaman_Tick);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn1.Location = new System.Drawing.Point(12, 331);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(248, 41);
            this.btn1.TabIndex = 62;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pbMilyoner
            // 
            this.pbMilyoner.Location = new System.Drawing.Point(127, 12);
            this.pbMilyoner.Name = "pbMilyoner";
            this.pbMilyoner.Size = new System.Drawing.Size(315, 192);
            this.pbMilyoner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMilyoner.TabIndex = 69;
            this.pbMilyoner.TabStop = false;
            // 
            // frmSoruEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCekil);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.pbMilyoner);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSoruEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruEkranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMilyoner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeyirci;
        private System.Windows.Forms.Button btnCiftCevap;
        private System.Windows.Forms.Button btnYuzde50;
        private System.Windows.Forms.Button btnTelefon;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        public System.Windows.Forms.Button btnCekil;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.PictureBox pbMilyoner;
        public System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btn4;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Timer tmrZaman;
        public System.Windows.Forms.Button btn1;
    }
}