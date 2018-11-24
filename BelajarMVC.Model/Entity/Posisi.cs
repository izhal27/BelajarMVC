using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarMVC.Model.Entity
{
   [Table('posisi')]
   public class Posisi
   {
      public int id { get; set; }
      public string nama { get; set; }
      public string keterangan { get; set; }
   }
}
