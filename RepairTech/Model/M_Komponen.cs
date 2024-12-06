using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    public class M_Komponen
    {
        [Key]
        public int id_komponen { get; set; }
        [Required]
        public string nama_komponen { get; set; }
        [Required]
        public decimal harga { get; set; }
        [Required]
        public int stok {  get; set; }

        public M_Komponen(string nama_komponen, decimal harga, int stok)
        {
            this.nama_komponen = nama_komponen;
            this.harga = harga;
            this.stok = stok;
        }

        public M_Komponen(int id_komponen, string nama_komponen, decimal harga, int stok)
        : this(nama_komponen, harga, stok)
        {
            this.id_komponen = id_komponen;
        }

        public M_Komponen()
        {
        }
    }
}