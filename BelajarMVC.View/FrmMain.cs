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
   public partial class FrmMain : Form, IListener
   {

      #region >> Fields <<

      private IPemainController _controller;
      private BindingListView<Pemain> _view;

      #endregion

      // ----------------------------------------------------------------------//
      
      #region >> Constructor <<

      public FrmMain()
      {
         InitializeComponent();
         _controller = new PemainController();
         LoadData();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> EventHandler Methods <<

      private void dgvPemain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
      {
         btnUbah_Click(null, null);
      }

      private void btnTambah_Click(object sender, EventArgs e)
      {
         var frm = new FrmOperasiPemain();
         frm.Listener = this;
         frm.ShowDialog();
      }

      private void btnUbah_Click(object sender, EventArgs e)
      {
         var id = GetID();
         var frm = new FrmOperasiPemain(id);
         if (frm.ShowDialog() == DialogResult.OK) LoadData();
      }

      private void btnHapus_Click(object sender, EventArgs e)
      {
         if (Message.Question("Anda yakin ingin menghapus data terpilih ?"))
         {
            var id = GetID();
            var result = _controller.Delete(new Pemain { id = id });

            if (result > 0)
            {
               Message.Info("Data berhasil dihapus.");
               LoadData();
            }
            else
            {
               Message.ErrorMessage();
            }
         }
      }

      private void btnDataPosisi_Click(object sender, EventArgs e)
      {
         new FrmPosisi().ShowDialog();
      }

      private void btClose_Click(object sender, EventArgs e)
      {
         Close();
      }

      #endregion

      // ----------------------------------------------------------------------//

      #region >> Methods <<

      private void LoadData()
      {
         try
         {
            var listOfPemain = _controller.GetAll();
            _view = new BindingListView<Pemain>(listOfPemain.ToList());
            dgvPemain.DataSource = _view;
            if (dgvPemain.DataSource != null) dgvPemain.Columns[0].Visible = false; // id
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }

      public void OK(object data = null)
      {
         LoadData();
      }

      private int GetID()
      {
         if (dgvPemain.SelectedRows != null)
         {
            return (int)dgvPemain.Rows[dgvPemain.CurrentRow.Index].Cells[0].Value;
         }

         return 0;
      }

      #endregion

   }
}
