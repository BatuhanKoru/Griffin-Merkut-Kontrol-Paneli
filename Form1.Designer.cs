namespace Griffin_Merkut_Kontrol_Paneli
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.genel_durum = new System.Windows.Forms.GroupBox();
            this.harita = new System.Windows.Forms.GroupBox();
            this.kamera_goruntusu = new System.Windows.Forms.GroupBox();
            this.yük_durumu = new System.Windows.Forms.GroupBox();
            this.ucak_motor_durumu_combo1 = new System.Windows.Forms.ComboBox();
            this.ucak_modu_combo2 = new System.Windows.Forms.ComboBox();
            this.ucak_adı_combo3 = new System.Windows.Forms.ComboBox();
            this.muhimmat_bırakma_button1 = new System.Windows.Forms.Button();
            this.yük_muhimmat_durumu_richtxt1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ucak_verileri = new System.Windows.Forms.GroupBox();
            this.batarya_progressbar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.irtifa_richtxt2 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hız_richtxt3 = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fps_ms_richtxt4 = new System.Windows.Forms.RichTextBox();
            this.genel_durum.SuspendLayout();
            this.kamera_goruntusu.SuspendLayout();
            this.yük_durumu.SuspendLayout();
            this.ucak_verileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "UÇAK:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "MOD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "MOTOR:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // genel_durum
            // 
            this.genel_durum.BackColor = System.Drawing.SystemColors.ControlLight;
            this.genel_durum.Controls.Add(this.ucak_adı_combo3);
            this.genel_durum.Controls.Add(this.ucak_modu_combo2);
            this.genel_durum.Controls.Add(this.ucak_motor_durumu_combo1);
            this.genel_durum.Controls.Add(this.label1);
            this.genel_durum.Controls.Add(this.label3);
            this.genel_durum.Controls.Add(this.label2);
            this.genel_durum.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genel_durum.Location = new System.Drawing.Point(12, 12);
            this.genel_durum.Name = "genel_durum";
            this.genel_durum.Size = new System.Drawing.Size(380, 194);
            this.genel_durum.TabIndex = 3;
            this.genel_durum.TabStop = false;
            this.genel_durum.Text = "GENEL DURUM";
            // 
            // harita
            // 
            this.harita.BackColor = System.Drawing.SystemColors.ControlLight;
            this.harita.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harita.Location = new System.Drawing.Point(418, 12);
            this.harita.Name = "harita";
            this.harita.Size = new System.Drawing.Size(783, 194);
            this.harita.TabIndex = 4;
            this.harita.TabStop = false;
            this.harita.Text = "HARİTA";
            // 
            // kamera_goruntusu
            // 
            this.kamera_goruntusu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kamera_goruntusu.Controls.Add(this.fps_ms_richtxt4);
            this.kamera_goruntusu.Controls.Add(this.label8);
            this.kamera_goruntusu.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kamera_goruntusu.Location = new System.Drawing.Point(418, 229);
            this.kamera_goruntusu.Name = "kamera_goruntusu";
            this.kamera_goruntusu.Size = new System.Drawing.Size(783, 474);
            this.kamera_goruntusu.TabIndex = 5;
            this.kamera_goruntusu.TabStop = false;
            this.kamera_goruntusu.Text = "KAMERA GÖRÜNTÜSÜ";
            // 
            // yük_durumu
            // 
            this.yük_durumu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.yük_durumu.Controls.Add(this.label4);
            this.yük_durumu.Controls.Add(this.yük_muhimmat_durumu_richtxt1);
            this.yük_durumu.Controls.Add(this.muhimmat_bırakma_button1);
            this.yük_durumu.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yük_durumu.Location = new System.Drawing.Point(13, 229);
            this.yük_durumu.Name = "yük_durumu";
            this.yük_durumu.Size = new System.Drawing.Size(379, 161);
            this.yük_durumu.TabIndex = 6;
            this.yük_durumu.TabStop = false;
            this.yük_durumu.Text = "YÜK DURUMU";
            // 
            // ucak_motor_durumu_combo1
            // 
            this.ucak_motor_durumu_combo1.FormattingEnabled = true;
            this.ucak_motor_durumu_combo1.Items.AddRange(new object[] {
            "ARM...",
            "DISEA..."});
            this.ucak_motor_durumu_combo1.Location = new System.Drawing.Point(105, 145);
            this.ucak_motor_durumu_combo1.Name = "ucak_motor_durumu_combo1";
            this.ucak_motor_durumu_combo1.Size = new System.Drawing.Size(255, 29);
            this.ucak_motor_durumu_combo1.TabIndex = 3;
            this.ucak_motor_durumu_combo1.SelectedIndexChanged += new System.EventHandler(this.ucak_motor_durumu_combo1_SelectedIndexChanged);
            // 
            // ucak_modu_combo2
            // 
            this.ucak_modu_combo2.FormattingEnabled = true;
            this.ucak_modu_combo2.Items.AddRange(new object[] {
            "OTOMATİK",
            "MANUEL"});
            this.ucak_modu_combo2.Location = new System.Drawing.Point(105, 86);
            this.ucak_modu_combo2.Name = "ucak_modu_combo2";
            this.ucak_modu_combo2.Size = new System.Drawing.Size(255, 29);
            this.ucak_modu_combo2.TabIndex = 4;
            // 
            // ucak_adı_combo3
            // 
            this.ucak_adı_combo3.FormattingEnabled = true;
            this.ucak_adı_combo3.Items.AddRange(new object[] {
            "GRIFFIN",
            "MERKUT"});
            this.ucak_adı_combo3.Location = new System.Drawing.Point(105, 26);
            this.ucak_adı_combo3.Name = "ucak_adı_combo3";
            this.ucak_adı_combo3.Size = new System.Drawing.Size(255, 29);
            this.ucak_adı_combo3.TabIndex = 5;
            // 
            // muhimmat_bırakma_button1
            // 
            this.muhimmat_bırakma_button1.BackColor = System.Drawing.Color.Red;
            this.muhimmat_bırakma_button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.muhimmat_bırakma_button1.ForeColor = System.Drawing.Color.White;
            this.muhimmat_bırakma_button1.Location = new System.Drawing.Point(208, 100);
            this.muhimmat_bırakma_button1.Name = "muhimmat_bırakma_button1";
            this.muhimmat_bırakma_button1.Size = new System.Drawing.Size(118, 43);
            this.muhimmat_bırakma_button1.TabIndex = 0;
            this.muhimmat_bırakma_button1.Text = "BIRAK";
            this.muhimmat_bırakma_button1.UseVisualStyleBackColor = false;
            // 
            // yük_muhimmat_durumu_richtxt1
            // 
            this.yük_muhimmat_durumu_richtxt1.Location = new System.Drawing.Point(163, 32);
            this.yük_muhimmat_durumu_richtxt1.Name = "yük_muhimmat_durumu_richtxt1";
            this.yük_muhimmat_durumu_richtxt1.Size = new System.Drawing.Size(196, 53);
            this.yük_muhimmat_durumu_richtxt1.TabIndex = 1;
            this.yük_muhimmat_durumu_richtxt1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "MÜHİMMAT:";
            // 
            // ucak_verileri
            // 
            this.ucak_verileri.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ucak_verileri.Controls.Add(this.label7);
            this.ucak_verileri.Controls.Add(this.hız_richtxt3);
            this.ucak_verileri.Controls.Add(this.label6);
            this.ucak_verileri.Controls.Add(this.irtifa_richtxt2);
            this.ucak_verileri.Controls.Add(this.label5);
            this.ucak_verileri.Controls.Add(this.batarya_progressbar);
            this.ucak_verileri.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucak_verileri.Location = new System.Drawing.Point(12, 414);
            this.ucak_verileri.Name = "ucak_verileri";
            this.ucak_verileri.Size = new System.Drawing.Size(380, 289);
            this.ucak_verileri.TabIndex = 7;
            this.ucak_verileri.TabStop = false;
            this.ucak_verileri.Text = "UÇAK VERİLERİ";
            // 
            // batarya_progressbar
            // 
            this.batarya_progressbar.BackColor = System.Drawing.Color.White;
            this.batarya_progressbar.Location = new System.Drawing.Point(164, 47);
            this.batarya_progressbar.Name = "batarya_progressbar";
            this.batarya_progressbar.Size = new System.Drawing.Size(196, 23);
            this.batarya_progressbar.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "BATARYA:";
            // 
            // irtifa_richtxt2
            // 
            this.irtifa_richtxt2.Location = new System.Drawing.Point(164, 126);
            this.irtifa_richtxt2.Name = "irtifa_richtxt2";
            this.irtifa_richtxt2.Size = new System.Drawing.Size(196, 40);
            this.irtifa_richtxt2.TabIndex = 7;
            this.irtifa_richtxt2.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(9, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "İRTİFA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(9, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 28);
            this.label7.TabIndex = 10;
            this.label7.Text = "HIZ:";
            // 
            // hız_richtxt3
            // 
            this.hız_richtxt3.Location = new System.Drawing.Point(164, 224);
            this.hız_richtxt3.Name = "hız_richtxt3";
            this.hız_richtxt3.Size = new System.Drawing.Size(196, 40);
            this.hız_richtxt3.TabIndex = 9;
            this.hız_richtxt3.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "FPS-ms:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // fps_ms_richtxt4
            // 
            this.fps_ms_richtxt4.Location = new System.Drawing.Point(102, 27);
            this.fps_ms_richtxt4.Name = "fps_ms_richtxt4";
            this.fps_ms_richtxt4.Size = new System.Drawing.Size(89, 28);
            this.fps_ms_richtxt4.TabIndex = 11;
            this.fps_ms_richtxt4.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1217, 722);
            this.Controls.Add(this.ucak_verileri);
            this.Controls.Add(this.yük_durumu);
            this.Controls.Add(this.kamera_goruntusu);
            this.Controls.Add(this.harita);
            this.Controls.Add(this.genel_durum);
            this.Name = "Form1";
            this.Text = "Griffin-Merkut Kontrol Paneli";
            this.genel_durum.ResumeLayout(false);
            this.genel_durum.PerformLayout();
            this.kamera_goruntusu.ResumeLayout(false);
            this.kamera_goruntusu.PerformLayout();
            this.yük_durumu.ResumeLayout(false);
            this.yük_durumu.PerformLayout();
            this.ucak_verileri.ResumeLayout(false);
            this.ucak_verileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox genel_durum;
        private System.Windows.Forms.GroupBox harita;
        private System.Windows.Forms.GroupBox kamera_goruntusu;
        private System.Windows.Forms.GroupBox yük_durumu;
        private System.Windows.Forms.ComboBox ucak_adı_combo3;
        private System.Windows.Forms.ComboBox ucak_modu_combo2;
        private System.Windows.Forms.ComboBox ucak_motor_durumu_combo1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox yük_muhimmat_durumu_richtxt1;
        private System.Windows.Forms.Button muhimmat_bırakma_button1;
        private System.Windows.Forms.GroupBox ucak_verileri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox hız_richtxt3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox irtifa_richtxt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar batarya_progressbar;
        private System.Windows.Forms.RichTextBox fps_ms_richtxt4;
        private System.Windows.Forms.Label label8;
    }
}

