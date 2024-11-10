using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    internal class M_DetailKomponen
    {
        [Key]
        public int id_detail_komponen { get; set; }
        [ForeignKey("M_Transaksi")]
        public int id_transaksi { get; set; }
        [ForeignKey("M_Komponen")]
        public int id_komponen { get; set; }
    } 
}
