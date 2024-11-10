using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    internal class M_Transaksi
    {
        [Key]
        public int id_transaksi { get; set; }
        [Required]
        public int no_faktur {  get; set; }
        [Required]
        public string tanggal { get; set; }
        [Required]
        public string nama_customer { get; set; }
        [Required]
        public string laptop { get; set; }
        [Required]
        [ForeignKey("M_Akun")]
        public int id_akun { get; set; }
    }
}
