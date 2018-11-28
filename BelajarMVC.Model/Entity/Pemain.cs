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
   [Table("pemain")]
   public class Pemain
   {
      [DisplayName("ID")]
      public int id { get; set; }
      [Required]
      [DisplayName("Nama")]
      public string nama { get; set; }
      [Required]
      [Browsable(false)]
      public int posisi_id { get; set; }
      [Write(false)]
      [DisplayName("Posisi")]
      public string posisi { get; set; }
      [Required]
      [DisplayName("Negara")]
      public string negara { get; set; }
      [DisplayName("Keterangan")]
      public string keterangan { get; set; }
   }
}
