using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;
using BelajarMVC.Model.Entity;
using BelajarMVC.Controller;
using Helper;

namespace BelajarMVC.View
{
   public partial class FrmPosisi : Form, IListener
   {

      #region >> Fields <<

      private IPosisiController _controller;
      private BindingListView<Posisi> _view;

      #endregion
      
      // ----------------------------------------------------------------------//

      #region >> Constructor <<

      public FrmPosisi()
      {
         InitializeComponent();
         _controller = new PosisiController();
         LoadData();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void btnTambah_Click(object sender, EventArgs e)
      {
         var frm = new FrmOperasiPosisi();
         frm.Listener = this;
         frm.ShowDialog();
      }

      private void btnUbah_Click(object sender, EventArgs e)
      {
         var id = GetID();
         var frm = new FrmOperasiPosisi(id);
         if (frm.ShowDialog() == DialogResult.OK) LoadData();
      }

      private void btnHapus_Click(object sender, EventArgs e)
      {
         if (Message.Question("Anda yakin ingin menghapus data terpilih ?"))
         {
            var id = GetID();
            var result = _controller.Delete(new Posisi { id = id });

            if (result > 0)
            {
               Message.Info("Data berhasil dihapus.");
               LoadData();
            }
            else
            {
               Message.Warning("Terjadi kesalahan saat melakukan operasi.\n"
                  + "Kemungkinan data sudah terpakai pada data 'Pemain'.");
            }
         }
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      private void LoadData()
      {
         try
         {
            var listOfPosisi = _controller.GetAll();
            _view = new BindingListView<Posisi>(listOfPosisi.ToList());
            dgvPosisi.DataSource = _view;
            if (dgvPosisi.DataSource != null) dgvPosisi.Columns[0].Visible = false; // id
         }
         catch (Exception ex)
         {
            Message.Error(ex.Message);
         }
      }

      public void OK(object data = null)
      {
         LoadData();
      }

      private int GetID()
      {
         if (dgvPosisi.SelectedRows != null)
         {
            return (int)dgvPosisi.Rows[dgvPosisi.CurrentRow.Index].Cells[0].Value;
         }

         return 0;
      }

      #endregion

      private void dgvPosisi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         btnUbah_Click(null, null);
      }
   }
}
