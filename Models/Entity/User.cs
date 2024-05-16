using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Jabatan { get; set; }
        public string Keterangan { get; set; }
    }
}
