using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarMVC.Model.Entity
{
   [Table("posisi")]
   public class Posisi
   {
      [DisplayName("ID")]
      public int id { get; set; }
      [Required]
      [DisplayName("Nama")]
      public string nama { get; set; }
      [DisplayName("Keterangan")]
      public string keterangan { get; set; }
   }
}
