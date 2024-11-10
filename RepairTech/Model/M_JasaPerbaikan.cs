using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    internal class M_JasaPerbaikan
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
    }
}
