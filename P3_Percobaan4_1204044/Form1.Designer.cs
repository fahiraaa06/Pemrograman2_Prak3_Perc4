namespace P3_Percobaan4_1204044
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.KelasGroupBox = new System.Windows.Forms.GroupBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.JadwalGroupBox = new System.Windows.Forms.GroupBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbJk = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.TampilButton = new System.Windows.Forms.Button();
            this.KelasGroupBox.SuspendLayout();
            this.JadwalGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Location = new System.Drawing.Point(273, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "&Selesai";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama               :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jenis Kelamin    :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Lahir    :";
            // 
            // KelasGroupBox
            // 
            this.KelasGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.KelasGroupBox.Controls.Add(this.cbPiano);
            this.KelasGroupBox.Controls.Add(this.cbBiola);
            this.KelasGroupBox.Controls.Add(this.cbGitar);
            this.KelasGroupBox.Controls.Add(this.checkBox3);
            this.KelasGroupBox.Controls.Add(this.cbDrum);
            this.KelasGroupBox.Controls.Add(this.cbVokal);
            this.KelasGroupBox.Controls.Add(this.cbKonduktor);
            this.KelasGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KelasGroupBox.ForeColor = System.Drawing.Color.Black;
            this.KelasGroupBox.Location = new System.Drawing.Point(36, 228);
            this.KelasGroupBox.Name = "KelasGroupBox";
            this.KelasGroupBox.Size = new System.Drawing.Size(200, 173);
            this.KelasGroupBox.TabIndex = 7;
            this.KelasGroupBox.TabStop = false;
            this.KelasGroupBox.Text = "Pilihan Kelas";
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(6, 21);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(62, 20);
            this.cbPiano.TabIndex = 14;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            this.cbPiano.CheckedChanged += new System.EventHandler(this.cbPiano_CheckedChanged);
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(6, 47);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(58, 20);
            this.cbBiola.TabIndex = 8;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(6, 70);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(55, 20);
            this.cbGitar.TabIndex = 9;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(0, -43);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 20);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(6, 95);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(59, 20);
            this.cbDrum.TabIndex = 11;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            this.cbDrum.CheckedChanged += new System.EventHandler(this.cbDrum_CheckedChanged);
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(6, 121);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbVokal.Size = new System.Drawing.Size(62, 20);
            this.cbVokal.TabIndex = 12;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            this.cbVokal.CheckedChanged += new System.EventHandler(this.cbVokal_CheckedChanged);
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(6, 147);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(87, 20);
            this.cbKonduktor.TabIndex = 13;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // JadwalGroupBox
            // 
            this.JadwalGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.JadwalGroupBox.Controls.Add(this.rbJadwal1);
            this.JadwalGroupBox.Controls.Add(this.rbJadwal2);
            this.JadwalGroupBox.Controls.Add(this.rbJadwal3);
            this.JadwalGroupBox.Controls.Add(this.rbJadwal4);
            this.JadwalGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JadwalGroupBox.Location = new System.Drawing.Point(254, 228);
            this.JadwalGroupBox.Name = "JadwalGroupBox";
            this.JadwalGroupBox.Size = new System.Drawing.Size(200, 173);
            this.JadwalGroupBox.TabIndex = 0;
            this.JadwalGroupBox.TabStop = false;
            this.JadwalGroupBox.Text = "Pilihan Jadwal";
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(6, 49);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(183, 20);
            this.rbJadwal1.TabIndex = 18;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin && Rabu, 14.00 -16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(6, 70);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(199, 20);
            this.rbJadwal2.TabIndex = 15;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(6, 94);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(198, 20);
            this.rbJadwal3.TabIndex = 16;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(6, 120);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(148, 20);
            this.rbJadwal4.TabIndex = 17;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(229, 117);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(179, 20);
            this.txtNama.TabIndex = 0;
            // 
            // cbJk
            // 
            this.cbJk.FormattingEnabled = true;
            this.cbJk.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
            this.cbJk.Location = new System.Drawing.Point(229, 143);
            this.cbJk.Name = "cbJk";
            this.cbJk.Size = new System.Drawing.Size(134, 21);
            this.cbJk.TabIndex = 1;
            this.cbJk.Text = "- pilih jenis kelamin -";
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(229, 173);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(134, 20);
            this.dtTglLahir.TabIndex = 2;
            // 
            // TampilButton
            // 
            this.TampilButton.BackColor = System.Drawing.Color.Salmon;
            this.TampilButton.Location = new System.Drawing.Point(142, 454);
            this.TampilButton.Name = "TampilButton";
            this.TampilButton.Size = new System.Drawing.Size(80, 35);
            this.TampilButton.TabIndex = 8;
            this.TampilButton.Text = "&Tampilkan";
            this.TampilButton.UseVisualStyleBackColor = false;
            this.TampilButton.Click += new System.EventHandler(this.TampilButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 539);
            this.Controls.Add(this.TampilButton);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.cbJk);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.JadwalGroupBox);
            this.Controls.Add(this.KelasGroupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Fahira Music School";
            this.KelasGroupBox.ResumeLayout(false);
            this.KelasGroupBox.PerformLayout();
            this.JadwalGroupBox.ResumeLayout(false);
            this.JadwalGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox KelasGroupBox;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.GroupBox JadwalGroupBox;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJk;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.Button TampilButton;
        private System.Windows.Forms.RadioButton rbJadwal1;
    }
}