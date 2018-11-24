using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarMVC.Model.Entity
{
   [Table('pemain')]
   public class Pemain
   {
      public int id { get; set; }
      public string nama { get; set; }
      public int posisi_id { get; set; }
      public string negara { get; set; }
      public string keterangan { get; set; }
   }
}
