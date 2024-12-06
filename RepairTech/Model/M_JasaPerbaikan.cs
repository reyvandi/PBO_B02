using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    public class M_JasaPerbaikan
    {
        [Key]
        public int id_jasa_perbaikan { get; set; }
        [Required]
        public string jenis_kerusakan { get; set; }
        [Required]
        public string solusi {  get; set; }
        [Required]
        public decimal biaya {  get; set; }
        [Required]
        public int estimasi_waktu { get; set; }

        public M_JasaPerbaikan(string jenis_kerusakan, string solusi, decimal biaya, int estimasi_waktu)
        {
            this.jenis_kerusakan = jenis_kerusakan;
            this.solusi = solusi;
            this.biaya = biaya;
            this.estimasi_waktu = estimasi_waktu;
        }

        public M_JasaPerbaikan(int id_jasa_perbaikan, string jenis_kerusakan, string solusi, decimal biaya, int estimasi_waktu)
        : this(jenis_kerusakan, solusi, biaya, estimasi_waktu)
        {
            this.id_jasa_perbaikan = id_jasa_perbaikan;
        }

        public M_JasaPerbaikan()
        {
        }
    }
}
