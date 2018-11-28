namespace BelajarMVC.View
{
   partial class FrmOperasiPemain
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOperasi = new System.Windows.Forms.Button();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.txtNama = new System.Windows.Forms.TextBox();
         this.cmbPosisi = new System.Windows.Forms.ComboBox();
         this.txtNegara = new System.Windows.Forms.TextBox();
         this.rtbKeterangan = new System.Windows.Forms.RichTextBox();
         this.groupBox1.SuspendLayout();
         this.tableLayoutPanel1.SuspendLayout();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.groupBox1.Controls.Add(this.btnCancel);
         this.groupBox1.Controls.Add(this.btnOperasi);
         this.groupBox1.Controls.Add(this.tableLayoutPanel1);
         this.groupBox1.Location = new System.Drawing.Point(12, 12);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(305, 246);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "[ Data ]";
         // 
         // btnCancel
         // 
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Location = new System.Drawing.Point(155, 213);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         // 
         // btnOperasi
         // 
         this.btnOperasi.Location = new System.Drawing.Point(74, 213);
         this.btnOperasi.Name = "btnOperasi";
         this.btnOperasi.Size = new System.Drawing.Size(75, 23);
         this.btnOperasi.TabIndex = 1;
         this.btnOperasi.Text = "Operasi";
         this.btnOperasi.UseVisualStyleBackColor = true;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 2;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
         this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
         this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
         this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
         this.tableLayoutPanel1.Controls.Add(this.txtNama, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.cmbPosisi, 1, 1);
         this.tableLayoutPanel1.Controls.Add(this.txtNegara, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.rtbKeterangan, 1, 3);
         this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 4;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
         this.tableLayoutPanel1.Size = new System.Drawing.Size(285, 188);
         this.tableLayoutPanel1.TabIndex = 0;
         // 
         // label1
         // 
         this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(3, 6);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(35, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nama";
         // 
         // label2
         // 
         this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(3, 33);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(34, 13);
         this.label2.TabIndex = 0;
         this.label2.Text = "Posisi";
         // 
         // label3
         // 
         this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(3, 59);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(42, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Negara";
         // 
         // label4
         // 
         this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(3, 127);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(62, 13);
         this.label4.TabIndex = 0;
         this.label4.Text = "Keterangan";
         // 
         // txtNama
         // 
         this.txtNama.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtNama.Location = new System.Drawing.Point(71, 3);
         this.txtNama.MaxLength = 100;
         this.txtNama.Name = "txtNama";
         this.txtNama.Size = new System.Drawing.Size(200, 20);
         this.txtNama.TabIndex = 1;
         // 
         // cmbPosisi
         // 
         this.cmbPosisi.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.cmbPosisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbPosisi.FormattingEnabled = true;
         this.cmbPosisi.Location = new System.Drawing.Point(71, 29);
         this.cmbPosisi.Name = "cmbPosisi";
         this.cmbPosisi.Size = new System.Drawing.Size(200, 21);
         this.cmbPosisi.TabIndex = 2;
         // 
         // txtNegara
         // 
         this.txtNegara.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.txtNegara.Location = new System.Drawing.Point(71, 56);
         this.txtNegara.MaxLength = 100;
         this.txtNegara.Name = "txtNegara";
         this.txtNegara.Size = new System.Drawing.Size(200, 20);
         this.txtNegara.TabIndex = 3;
         // 
         // rtbKeterangan
         // 
         this.rtbKeterangan.Anchor = System.Windows.Forms.AnchorStyles.Left;
         this.rtbKeterangan.Location = new System.Drawing.Point(71, 85);
         this.rtbKeterangan.MaxLength = 100;
         this.rtbKeterangan.Name = "rtbKeterangan";
         this.rtbKeterangan.Size = new System.Drawing.Size(200, 96);
         this.rtbKeterangan.TabIndex = 4;
         this.rtbKeterangan.Text = "";
         // 
         // FrmOperasiPemain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(329, 270);
         this.Controls.Add(this.groupBox1);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "FrmOperasiPemain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Operasi Pemain";
         this.groupBox1.ResumeLayout(false);
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOperasi;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txtNama;
      private System.Windows.Forms.ComboBox cmbPosisi;
      private System.Windows.Forms.TextBox txtNegara;
      private System.Windows.Forms.RichTextBox rtbKeterangan;
   }
}