using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    public class M_Teknisi
    {
        [Key]
        public int id_teknisi { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string keahlian { get; set; }
        [Required]
        public string jam_kerja {  get; set; }
        [Required]
        public string alamat { get; set; }
        [Required]
        public string no_telepon { get; set; }
    }
}
