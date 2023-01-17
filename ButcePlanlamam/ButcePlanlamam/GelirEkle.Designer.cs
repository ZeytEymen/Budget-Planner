namespace ButcePlanlamam
{
    partial class GelirEkle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxKategori = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnCik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tutar :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Not :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tarih :";
            // 
            // cboxKategori
            // 
            this.cboxKategori.BackColor = System.Drawing.Color.Honeydew;
            this.cboxKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxKategori.FormattingEnabled = true;
            this.cboxKategori.Location = new System.Drawing.Point(126, 90);
            this.cboxKategori.Name = "cboxKategori";
            this.cboxKategori.Size = new System.Drawing.Size(176, 26);
            this.cboxKategori.TabIndex = 1;
            // 
            // txtTutar
            // 
            this.txtTutar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTutar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTutar.Location = new System.Drawing.Point(126, 133);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(176, 22);
            this.txtTutar.TabIndex = 2;
            // 
            // txtNot
            // 
            this.txtNot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNot.Location = new System.Drawing.Point(126, 176);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(176, 59);
            this.txtNot.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 250);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::ButcePlanlamam.Properties.Resources.kaydet;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(142, 294);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(65, 65);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnCik
            // 
            this.btnCik.BackgroundImage = global::ButcePlanlamam.Properties.Resources.geri;
            this.btnCik.FlatAppearance.BorderSize = 0;
            this.btnCik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCik.Location = new System.Drawing.Point(267, 329);
            this.btnCik.Name = "btnCik";
            this.btnCik.Size = new System.Drawing.Size(65, 65);
            this.btnCik.TabIndex = 5;
            this.btnCik.UseVisualStyleBackColor = true;
            this.btnCik.Click += new System.EventHandler(this.btnCik_Click);
            // 
            // GelirEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ButcePlanlamam.Properties.Resources.Gelır_Ekle;
            this.ClientSize = new System.Drawing.Size(350, 400);
            this.Controls.Add(this.btnCik);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cboxKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GelirEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GelirEkle";
            this.Load += new System.EventHandler(this.GelirEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxKategori;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCik;
    }
}