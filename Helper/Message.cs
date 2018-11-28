using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelajarMVC.View
{
   public static class Message
   {

      public static void Info(string message)
      {
         MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }

      public static bool Question(string message)
      {
         return MessageBox.Show(message, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes;
      }

      public static void Warning(string message)
      {
         MessageBox.Show(message, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }

      public static void Error(string message)
      {
         MessageBox.Show(message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      public static void ErrorMessage()
      {
         Warning("Terjadi kesalahan saat melakukan operasi.");
      }

   }
}
