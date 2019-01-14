namespace BelajarMVC.View
{
   partial class FrmMain
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
         this.dgvPemain = new System.Windows.Forms.DataGridView();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btClose = new System.Windows.Forms.Button();
         this.btnDataPosisi = new System.Windows.Forms.Button();
         this.btnHapus = new System.Windows.Forms.Button();
         this.btnUbah = new System.Windows.Forms.Button();
         this.btnTambah = new System.Windows.Forms.Button();
         this.btnBackupDatabase = new System.Windows.Forms.Button();
         this.btnRestoreDatabase = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dgvPemain)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // dgvPemain
         // 
         this.dgvPemain.AllowUserToAddRows = false;
         this.dgvPemain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dgvPemain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.dgvPemain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvPemain.Location = new System.Drawing.Point(12, 41);
         this.dgvPemain.MultiSelect = false;
         this.dgvPemain.Name = "dgvPemain";
         this.dgvPemain.ReadOnly = true;
         this.dgvPemain.Size = new System.Drawing.Size(629, 365);
         this.dgvPemain.TabIndex = 0;
         this.dgvPemain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPemain_CellDoubleClick);
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.btClose);
         this.groupBox1.Controls.Add(this.btnDataPosisi);
         this.groupBox1.Controls.Add(this.btnHapus);
         this.groupBox1.Controls.Add(this.btnUbah);
         this.groupBox1.Controls.Add(this.btnTambah);
         this.groupBox1.Location = new System.Drawing.Point(12, 412);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(629, 48);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ Operasi ]";
         // 
         // btClose
         // 
         this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btClose.Location = new System.Drawing.Point(548, 19);
         this.btClose.Name = "btClose";
         this.btClose.Size = new System.Drawing.Size(75, 23);
         this.btClose.TabIndex = 10;
         this.btClose.Text = "Tutu&p";
         this.btClose.UseVisualStyleBackColor = true;
         this.btClose.Click += new System.EventHandler(this.btClose_Click);
         // 
         // btnDataPosisi
         // 
         this.btnDataPosisi.Location = new System.Drawing.Point(249, 19);
         this.btnDataPosisi.Name = "btnDataPosisi";
         this.btnDataPosisi.Size = new System.Drawing.Size(75, 23);
         this.btnDataPosisi.TabIndex = 4;
         this.btnDataPosisi.Text = "&Data Posisi";
         this.btnDataPosisi.UseVisualStyleBackColor = true;
         this.btnDataPosisi.Click += new System.EventHandler(this.btnDataPosisi_Click);
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
         // btnBackupDatabase
         // 
         this.btnBackupDatabase.Location = new System.Drawing.Point(12, 12);
         this.btnBackupDatabase.Name = "btnBackupDatabase";
         this.btnBackupDatabase.Size = new System.Drawing.Size(120, 23);
         this.btnBackupDatabase.TabIndex = 2;
         this.btnBackupDatabase.TabStop = false;
         this.btnBackupDatabase.Text = "&Backup Database";
         this.btnBackupDatabase.UseVisualStyleBackColor = true;
         this.btnBackupDatabase.Click += new System.EventHandler(this.btnBackupDatabase_Click);
         // 
         // btnRestoreDatabase
         // 
         this.btnRestoreDatabase.Location = new System.Drawing.Point(138, 12);
         this.btnRestoreDatabase.Name = "btnRestoreDatabase";
         this.btnRestoreDatabase.Size = new System.Drawing.Size(120, 23);
         this.btnRestoreDatabase.TabIndex = 2;
         this.btnRestoreDatabase.TabStop = false;
         this.btnRestoreDatabase.Text = "&RestoreDatabase";
         this.btnRestoreDatabase.UseVisualStyleBackColor = true;
         this.btnRestoreDatabase.Click += new System.EventHandler(this.btnRestoreDatabase_Click);
         // 
         // FrmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(653, 472);
         this.Controls.Add(this.btnRestoreDatabase);
         this.Controls.Add(this.btnBackupDatabase);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.dgvPemain);
         this.Name = "FrmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "DATA PEMAIN";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         ((System.ComponentModel.ISupportInitialize)(this.dgvPemain)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataGridView dgvPemain;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.Button btClose;
      private System.Windows.Forms.Button btnDataPosisi;
      private System.Windows.Forms.Button btnHapus;
      private System.Windows.Forms.Button btnUbah;
      private System.Windows.Forms.Button btnTambah;
      private System.Windows.Forms.Button btnBackupDatabase;
      private System.Windows.Forms.Button btnRestoreDatabase;
   }
}

