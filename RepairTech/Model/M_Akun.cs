using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_PBO.Model
{
    internal class M_Akun
    {
        [Key]
        public int id_akun { get; set; }
        [Required]
        public string username { get; set; }
        [Required] 
        public string password { get; set; }
        [Required]
        public string role { get; set; }
        [Required]
        public string email { get; set; }
    }
}
