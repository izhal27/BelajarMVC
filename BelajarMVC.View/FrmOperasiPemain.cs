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
   public partial class FrmOperasiPemain : Form
   {

      #region >> Fields <<

      private IPemainController _pemainController;
      private IPosisiController _posisiController;
      public IListener Listener { get; set; }
      private int _id;

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Properties <<


      #endregion

      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmOperasiPemain()
      {
         InitializeComponent();
         _pemainController = new PemainController();
         _posisiController = new PosisiController();
         SetControls();
      }

      public FrmOperasiPemain(int id)
      {
         InitializeComponent();
         _pemainController = new PemainController();
         _posisiController = new PosisiController();
         _id = id;
         SetControls(true, id);
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<


      private void Tambah_Click(object sender, EventArgs e)
      {
         if (CekControls() && Message.Question("Tambah data pemain ?"))
         {
            var pemain = GetPemain();

            var result = _pemainController.Save(pemain);

            PemainExist(result);

            if (result > 0)
            {
               Message.Info("Pemain berhasil ditambahkan.");
               ClearControls(this);
               cmbPosisi.SelectedIndex = -1;
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
         if (CekControls() && Message.Question("Simpan data pemain ?"))
         {
            var pemain = GetPemain();
            pemain.id = _id;

            var result = _pemainController.Update(pemain);

            PemainExist(result);

            if (result > 0)
            {
               Message.Info("Data pemain berhasil disimpan.");
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

               Text = "Ubah Pemain";
               btnOperasi.Text = "&Simpan";
               btnOperasi.Click += Simpan_Click;

               break;
            // Tambah data
            default:

               Text = "Tambah Pemain";
               btnOperasi.Text = "&Tambah";
               btnOperasi.Click += Tambah_Click;

               break;
         }

         InputDataControls(isEdited, id);

         ActiveControl = btnCancel;
      }

      private void InputDataControls(bool isEdited = false, int id = 0)
      {
         cmbPosisi.DataSource = new BindingSource(_posisiController.GetAll(), null);
         cmbPosisi.ValueMember = "id";
         cmbPosisi.DisplayMember = "nama";

         switch (isEdited)
         {
            // Ubah data
            case true:

               var pemain = _pemainController.GetByID(id);
               txtNama.Text = pemain.nama;
               cmbPosisi.SelectedValue = pemain.posisi_id;
               txtNegara.Text = pemain.negara;
               rtbKeterangan.Text = pemain.keterangan;

               break;
            // Tambah data
            default:

               cmbPosisi.SelectedIndex = -1;

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
            Message.Warning("Nama pemain harus diisi.");
            txtNama.Focus();
            return false;
         }
         else if (cmbPosisi.SelectedIndex == -1)
         {
            Message.Warning("Anda belum memilih posisi.");
            cmbPosisi.Focus();
            return false;
         }
         else if (string.IsNullOrWhiteSpace(txtNegara.Text))
         {
            Message.Warning("Nama negara harus diisi.");
            txtNegara.Focus();
            return false;
         }

         return true;
      }

      private Pemain GetPemain()
      {
         var pemain = new Pemain
         {
            nama = txtNama.Text.Trim(),
            posisi_id = (int)cmbPosisi.SelectedValue,
            negara = txtNegara.Text.Trim(),
            keterangan = rtbKeterangan.Text.Trim()
         };

         return pemain;
      }

      private void PemainExist(int result)
      {
         if (result == -1)
         {
            Message.Warning("Nama pemain sudah ada di database.");
            txtNama.Focus();
         }
      }

      #endregion

   }
}
