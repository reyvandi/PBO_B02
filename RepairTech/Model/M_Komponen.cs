using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    internal class M_Komponen
    {
        [Key]
        public int id_komponen { get; set; }
        [Required]
        public string nama_komponen { get; set; }
        [Required]
        public decimal harga { get; set; }
        [Required]
        public int stok {  get; set; }
    }
}
