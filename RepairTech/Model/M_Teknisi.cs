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

        public M_Teknisi(string nama, string keahlian, string jam_kerja, string alamat, string no_telepon)
        {
            this.nama = nama;
            this.keahlian = keahlian;
            this.jam_kerja = jam_kerja;
            this.alamat = alamat;
            this.no_telepon = no_telepon;
        }

        public M_Teknisi(int id_teknisi, string nama, string keahlian, string jam_kerja, string alamat, string no_telepon)
        : this(nama, keahlian, jam_kerja, alamat, no_telepon)
        {
            this.id_teknisi = id_teknisi;
        }

        public M_Teknisi()
        {
        }
    }
}
