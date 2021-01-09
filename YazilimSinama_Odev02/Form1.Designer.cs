namespace YazilimSinama_Odev02
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
            this.dgAlan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBuyukluk = new System.Windows.Forms.TextBox();
            this.btnCoz = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctCheese = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctYol = new System.Windows.Forms.PictureBox();
            this.pctWall = new System.Windows.Forms.PictureBox();
            this.pctMouse = new System.Windows.Forms.PictureBox();
            this.txtAdimSayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlan
            // 
            this.dgAlan.AllowUserToAddRows = false;
            this.dgAlan.AllowUserToDeleteRows = false;
            this.dgAlan.AllowUserToResizeColumns = false;
            this.dgAlan.AllowUserToResizeRows = false;
            this.dgAlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlan.ColumnHeadersVisible = false;
            this.dgAlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgAlan.Location = new System.Drawing.Point(9, 10);
            this.dgAlan.Margin = new System.Windows.Forms.Padding(2);
            this.dgAlan.Name = "dgAlan";
            this.dgAlan.ReadOnly = true;
            this.dgAlan.RowHeadersVisible = false;
            this.dgAlan.RowTemplate.Height = 24;
            this.dgAlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgAlan.Size = new System.Drawing.Size(525, 569);
            this.dgAlan.TabIndex = 0;
            this.dgAlan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlan_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Image = global::YazilimSinama_Odev02.Properties.Resources.duvar;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // txtBuyukluk
            // 
            this.txtBuyukluk.Location = new System.Drawing.Point(541, 232);
            this.txtBuyukluk.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuyukluk.Name = "txtBuyukluk";
            this.txtBuyukluk.Size = new System.Drawing.Size(109, 20);
            this.txtBuyukluk.TabIndex = 1;
            this.txtBuyukluk.Text = "10";
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(541, 312);
            this.btnCoz.Margin = new System.Windows.Forms.Padding(2);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(108, 34);
            this.btnCoz.TabIndex = 2;
            this.btnCoz.Text = "Başla";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(541, 255);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(2);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(108, 52);
            this.btnOlustur.TabIndex = 3;
            this.btnOlustur.Text = "Labirenti Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seçili";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pctCheese);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pctYol);
            this.groupBox1.Controls.Add(this.pctWall);
            this.groupBox1.Controls.Add(this.pctMouse);
            this.groupBox1.Location = new System.Drawing.Point(541, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(178, 139);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eklenebilir Elemanlar";
            // 
            // pctCheese
            // 
            this.pctCheese.Image = global::YazilimSinama_Odev02.Properties.Resources.finish;
            this.pctCheese.Location = new System.Drawing.Point(4, 17);
            this.pctCheese.Margin = new System.Windows.Forms.Padding(2);
            this.pctCheese.Name = "pctCheese";
            this.pctCheese.Size = new System.Drawing.Size(38, 41);
            this.pctCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCheese.TabIndex = 4;
            this.pctCheese.TabStop = false;
            this.pctCheese.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 57);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buradan seçim yaptıktan sonra grid üzerine tıklayarak labirenti oluşturunuz.";
            // 
            // pctYol
            // 
            this.pctYol.Image = global::YazilimSinama_Odev02.Properties.Resources.yol;
            this.pctYol.Location = new System.Drawing.Point(130, 17);
            this.pctYol.Margin = new System.Windows.Forms.Padding(2);
            this.pctYol.Name = "pctYol";
            this.pctYol.Size = new System.Drawing.Size(38, 41);
            this.pctYol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctYol.TabIndex = 9;
            this.pctYol.TabStop = false;
            this.pctYol.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pctWall
            // 
            this.pctWall.Image = global::YazilimSinama_Odev02.Properties.Resources.duvar;
            this.pctWall.Location = new System.Drawing.Point(46, 17);
            this.pctWall.Margin = new System.Windows.Forms.Padding(2);
            this.pctWall.Name = "pctWall";
            this.pctWall.Size = new System.Drawing.Size(38, 41);
            this.pctWall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctWall.TabIndex = 5;
            this.pctWall.TabStop = false;
            this.pctWall.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pctMouse
            // 
            this.pctMouse.Image = global::YazilimSinama_Odev02.Properties.Resources.tas;
            this.pctMouse.Location = new System.Drawing.Point(88, 17);
            this.pctMouse.Margin = new System.Windows.Forms.Padding(2);
            this.pctMouse.Name = "pctMouse";
            this.pctMouse.Size = new System.Drawing.Size(38, 41);
            this.pctMouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMouse.TabIndex = 6;
            this.pctMouse.TabStop = false;
            this.pctMouse.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // txtAdimSayisi
            // 
            this.txtAdimSayisi.Enabled = false;
            this.txtAdimSayisi.Location = new System.Drawing.Point(541, 452);
            this.txtAdimSayisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdimSayisi.Name = "txtAdimSayisi";
            this.txtAdimSayisi.Size = new System.Drawing.Size(109, 20);
            this.txtAdimSayisi.TabIndex = 11;
            this.txtAdimSayisi.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 436);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Adım Sayısı";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Column1";
            this.dataGridViewImageColumn1.Image = global::YazilimSinama_Odev02.Properties.Resources.duvar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(541, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 609);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdimSayisi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.txtBuyukluk);
            this.Controls.Add(this.dgAlan);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Yazılım Sınama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctCheese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctYol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlan;
        private System.Windows.Forms.TextBox txtBuyukluk;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.PictureBox pctCheese;
        private System.Windows.Forms.PictureBox pctWall;
        private System.Windows.Forms.PictureBox pctMouse;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctYol;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdimSayisi;
        private System.Windows.Forms.Label label3;
    }
}

