using BelajarMVC.Controller;
using BelajarMVC.Model.Entity;
using Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarMVC.View
{
   public partial class FrmOperasiPosisi : Form
   {

      #region >> Fields <<
      
      private IPosisiController _posisiController;
      public IListener Listener { get; set; }
      private int _id;

      #endregion
      
      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmOperasiPosisi()
      {
         InitializeComponent();
         _posisiController = new PosisiController();
         SetControls();
      }

      public FrmOperasiPosisi(int id)
      {
         InitializeComponent();
         _posisiController = new PosisiController();
         _id = id;
         SetControls(true, id);
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void Tambah_Click(object sender, EventArgs e)
      {
         if (CekControls() && Message.Question("Tambah data posisi ?"))
         {
            var posisi = GetPosisi();

            var result = _posisiController.Save(posisi);

            PosisiExist(result);

            if (result > 0)
            {
               Message.Info("Posisi berhasil ditambahkan.");
               ClearControls(this);
               Listener.OK();
            }
            else
            {
               Message.ErrorMessage();
            }
         }
      }

      private void Simpan_Click(object sender, EventArgs e)
      {
         if (CekControls() && Message.Question("Simpan data posisi ?"))
         {
            var posisi = GetPosisi();
            posisi.id = _id;

            var result = _posisiController.Update(posisi);

            PosisiExist(result);

            if (result > 0)
            {
               Message.Info("Data posisi berhasil disimpan.");
               DialogResult = DialogResult.OK;
               Close();
            }
            else
            {
               Message.ErrorMessage();
            }
         }
      }
      
      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      private void SetControls(bool isEdited = false, int id = 0)
      {
         switch (isEdited)
         {
            // Ubah data
            case true:

               Text = "Ubah Posisi";
               btnOperasi.Text = "&Simpan";
               btnOperasi.Click += Simpan_Click;

               break;
            // Tambah data
            default:

               Text = "Tambah Posisi";
               btnOperasi.Text = "&Tambah";
               btnOperasi.Click += Tambah_Click;

               break;
         }

         InputDataControls(isEdited, id);

         ActiveControl = btnCancel;
      }

      private void InputDataControls(bool isEdited = false, int id = 0)
      {
         switch (isEdited)
         {
            // Ubah data
            case true:

               var posisi = _posisiController.GetByID(id);
               txtNama.Text = posisi.nama;
               rtbKeterangan.Text = posisi.keterangan;

               break;
            // Tambah data
            default:
               break;
         }
      }

      private void ClearControls(Control control)
      {
         foreach (Control item in control.Controls)
         {
            if (item is TextBox)
            {
               ((TextBox)item).Clear();
            }

            if (item is RichTextBox)
            {
               ((RichTextBox)item).Clear();
            }

            ClearControls(item);
         }
      }

      private bool CekControls()
      {
         if (string.IsNullOrWhiteSpace(txtNama.Text))
         {
            Message.Warning("Nama posisi harus diisi.");
            txtNama.Focus();
            return false;
         }

         return true;
      }

      private Posisi GetPosisi()
      {
         var posisi = new Posisi
         {
            nama = txtNama.Text.Trim(),
            keterangan = rtbKeterangan.Text.Trim()
         };

         return posisi;
      }

      private void PosisiExist(int result)
      {
         if (result == -1)
         {
            Message.Warning("Nama posisi sudah ada di database.");
            txtNama.Focus();
         }
      }

      #endregion

   }
}
