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
        public DateTime tanggal { get; set; }
        public string laptop { get; set; }
        public string alamat { get; set; }
        public string status_transaksi { get; set; }
        [Required]
        [ForeignKey("M_Akun")]
        public int id_akun { get; set; }
        [ForeignKey("M_Teknisi")]
        public int id_teknisi { get; set; }
    }
}
