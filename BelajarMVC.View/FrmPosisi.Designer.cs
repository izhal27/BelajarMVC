namespace BelajarMVC.View
{
   partial class FrmPosisi
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
         this.dgvPosisi = new System.Windows.Forms.DataGridView();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnTutup = new System.Windows.Forms.Button();
         this.btnHapus = new System.Windows.Forms.Button();
         this.btnUbah = new System.Windows.Forms.Button();
         this.btnTambah = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgvPosisi)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvPosisi
         // 
         this.dgvPosisi.AllowUserToAddRows = false;
         this.dgvPosisi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvPosisi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvPosisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvPosisi.Location = new System.Drawing.Point(12, 12);
         this.dgvPosisi.MultiSelect = false;
         this.dgvPosisi.Name = "dgvPosisi";
         this.dgvPosisi.ReadOnly = true;
         this.dgvPosisi.Size = new System.Drawing.Size(710, 326);
         this.dgvPosisi.TabIndex = 0;
         this.dgvPosisi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosisi_CellDoubleClick);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.btnTutup);
         this.groupBox1.Controls.Add(this.btnHapus);
         this.groupBox1.Controls.Add(this.btnUbah);
         this.groupBox1.Controls.Add(this.btnTambah);
         this.groupBox1.Location = new System.Drawing.Point(12, 344);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(710, 48);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ Operasi ]";
         // 
         // btnTutup
         // 
         this.btnTutup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnTutup.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnTutup.Location = new System.Drawing.Point(629, 19);
         this.btnTutup.Name = "btnTutup";
         this.btnTutup.Size = new System.Drawing.Size(75, 23);
         this.btnTutup.TabIndex = 10;
         this.btnTutup.Text = "Tutu&p";
         this.btnTutup.UseVisualStyleBackColor = true;
         // 
         // btnHapus
         // 
         this.btnHapus.Location = new System.Drawing.Point(168, 19);
         this.btnHapus.Name = "btnHapus";
         this.btnHapus.Size = new System.Drawing.Size(75, 23);
         this.btnHapus.TabIndex = 3;
         this.btnHapus.Text = "&Hapus";
         this.btnHapus.UseVisualStyleBackColor = true;
         this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
         // 
         // btnUbah
         // 
         this.btnUbah.Location = new System.Drawing.Point(87, 19);
         this.btnUbah.Name = "btnUbah";
         this.btnUbah.Size = new System.Drawing.Size(75, 23);
         this.btnUbah.TabIndex = 2;
         this.btnUbah.Text = "&Ubah";
         this.btnUbah.UseVisualStyleBackColor = true;
         this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
         // 
         // btnTambah
         // 
         this.btnTambah.Location = new System.Drawing.Point(6, 19);
         this.btnTambah.Name = "btnTambah";
         this.btnTambah.Size = new System.Drawing.Size(75, 23);
         this.btnTambah.TabIndex = 1;
         this.btnTambah.Text = "&Tambah";
         this.btnTambah.UseVisualStyleBackColor = true;
         this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
         // 
         // FrmPosisi
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(734, 404);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.dgvPosisi);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmPosisi";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "DATA POSISI";
         ((System.ComponentModel.ISupportInitialize)(this.dgvPosisi)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvPosisi;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btnTambah;
      private System.Windows.Forms.Button btnTutup;
      private System.Windows.Forms.Button btnHapus;
      private System.Windows.Forms.Button btnUbah;
   }
}