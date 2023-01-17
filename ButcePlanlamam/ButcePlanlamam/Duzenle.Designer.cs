namespace ButcePlanlamam
{
    partial class Duzenle
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnGelirSil = new System.Windows.Forms.Button();
            this.listGelir = new System.Windows.Forms.ListBox();
            this.listGider = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiderSil = new System.Windows.Forms.Button();
            this.btnKayitSi = new System.Windows.Forms.Button();
            this.txtGider = new System.Windows.Forms.TextBox();
            this.txtGelir = new System.Windows.Forms.TextBox();
            this.btnGider = new System.Windows.Forms.Button();
            this.btnGelir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(565, 320);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "GELİR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(414, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tutar :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(490, 12);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(135, 20);
            this.txtTutar.TabIndex = 2;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(711, 13);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(222, 80);
            this.txtNot.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(652, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Not :";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.FlatAppearance.BorderSize = 2;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(399, 84);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(88, 36);
            this.btnDuzenle.TabIndex = 6;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnGelirSil
            // 
            this.btnGelirSil.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGelirSil.FlatAppearance.BorderSize = 2;
            this.btnGelirSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelirSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelirSil.Location = new System.Drawing.Point(44, 281);
            this.btnGelirSil.Name = "btnGelirSil";
            this.btnGelirSil.Size = new System.Drawing.Size(136, 34);
            this.btnGelirSil.TabIndex = 6;
            this.btnGelirSil.Text = "Kategoriyi Sil";
            this.btnGelirSil.UseVisualStyleBackColor = true;
            this.btnGelirSil.Click += new System.EventHandler(this.btnGelirSil_Click);
            // 
            // listGelir
            // 
            this.listGelir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.listGelir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listGelir.FormattingEnabled = true;
            this.listGelir.ItemHeight = 16;
            this.listGelir.Location = new System.Drawing.Point(37, 71);
            this.listGelir.Name = "listGelir";
            this.listGelir.Size = new System.Drawing.Size(150, 194);
            this.listGelir.TabIndex = 7;
            // 
            // listGider
            // 
            this.listGider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.listGider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listGider.FormattingEnabled = true;
            this.listGider.ItemHeight = 16;
            this.listGider.Location = new System.Drawing.Point(218, 71);
            this.listGider.Name = "listGider";
            this.listGider.Size = new System.Drawing.Size(150, 194);
            this.listGider.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "GİDER";
            // 
            // btnGiderSil
            // 
            this.btnGiderSil.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnGiderSil.FlatAppearance.BorderSize = 2;
            this.btnGiderSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiderSil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiderSil.Location = new System.Drawing.Point(226, 281);
            this.btnGiderSil.Name = "btnGiderSil";
            this.btnGiderSil.Size = new System.Drawing.Size(136, 34);
            this.btnGiderSil.TabIndex = 6;
            this.btnGiderSil.Text = "Kategoriyi Sil";
            this.btnGiderSil.UseVisualStyleBackColor = true;
            this.btnGiderSil.Click += new System.EventHandler(this.btnGiderSil_Click);
            // 
            // btnKayitSi
            // 
            this.btnKayitSi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnKayitSi.FlatAppearance.BorderSize = 2;
            this.btnKayitSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitSi.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSi.Location = new System.Drawing.Point(512, 84);
            this.btnKayitSi.Name = "btnKayitSi";
            this.btnKayitSi.Size = new System.Drawing.Size(113, 36);
            this.btnKayitSi.TabIndex = 6;
            this.btnKayitSi.Text = "Kaydı Sil";
            this.btnKayitSi.UseVisualStyleBackColor = true;
            this.btnKayitSi.Click += new System.EventHandler(this.btnKayitSi_Click);
            // 
            // txtGider
            // 
            this.txtGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGider.Location = new System.Drawing.Point(218, 340);
            this.txtGider.Name = "txtGider";
            this.txtGider.Size = new System.Drawing.Size(150, 22);
            this.txtGider.TabIndex = 11;
            // 
            // txtGelir
            // 
            this.txtGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGelir.Location = new System.Drawing.Point(37, 340);
            this.txtGelir.Name = "txtGelir";
            this.txtGelir.Size = new System.Drawing.Size(150, 22);
            this.txtGelir.TabIndex = 12;
            // 
            // btnGider
            // 
            this.btnGider.FlatAppearance.BorderSize = 2;
            this.btnGider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGider.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGider.Location = new System.Drawing.Point(240, 380);
            this.btnGider.Name = "btnGider";
            this.btnGider.Size = new System.Drawing.Size(104, 34);
            this.btnGider.TabIndex = 9;
            this.btnGider.Text = "Yeni Ekle";
            this.btnGider.UseVisualStyleBackColor = true;
            this.btnGider.Click += new System.EventHandler(this.btnGider_Click);
            // 
            // btnGelir
            // 
            this.btnGelir.FlatAppearance.BorderSize = 2;
            this.btnGelir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGelir.Location = new System.Drawing.Point(58, 380);
            this.btnGelir.Name = "btnGelir";
            this.btnGelir.Size = new System.Drawing.Size(104, 34);
            this.btnGelir.TabIndex = 10;
            this.btnGelir.Text = "Yeni Ekle";
            this.btnGelir.UseVisualStyleBackColor = true;
            this.btnGelir.Click += new System.EventHandler(this.btnGelir_Click);
            // 
            // Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(217)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(976, 491);
            this.Controls.Add(this.txtGider);
            this.Controls.Add(this.txtGelir);
            this.Controls.Add(this.btnGider);
            this.Controls.Add(this.btnGelir);
            this.Controls.Add(this.listGider);
            this.Controls.Add(this.listGelir);
            this.Controls.Add(this.btnKayitSi);
            this.Controls.Add(this.btnGiderSil);
            this.Controls.Add(this.btnGelirSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Duzenle";
            this.Text = "Duzenle";
            this.Load += new System.EventHandler(this.Duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnGelirSil;
        private System.Windows.Forms.ListBox listGelir;
        private System.Windows.Forms.ListBox listGider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiderSil;
        private System.Windows.Forms.Button btnKayitSi;
        private System.Windows.Forms.TextBox txtGider;
        private System.Windows.Forms.TextBox txtGelir;
        private System.Windows.Forms.Button btnGider;
        private System.Windows.Forms.Button btnGelir;
    }
}