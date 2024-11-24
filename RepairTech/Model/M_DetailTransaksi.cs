using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    internal class M_DetailTransaksi
    {
        [Key]
        public int id_detail_transaksi { get; set; }
        [ForeignKey("M_Transaksi")]
        public int id_transaksi { get; set; }
        [ForeignKey("M_JasaPerbaikan")]
        public int id_jasa_perbaikan { get; set; }
        public decimal biaya { get; set; }
    }
}
