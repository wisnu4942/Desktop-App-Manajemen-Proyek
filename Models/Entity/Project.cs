using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string ProjectNama { get; set; }
        public string ProjectDeskripsi { get; set; }
        public DateTime ProjectWaktuMulai { get; set; }
        public DateTime ProjectWaktuSelesai { get; set; }
        public int ProjectAnggaran { get; set; }
        public string ProjectStatus { get; set; }
        public string UserId { get; set; }
        public string ProjectLokasi { get; set; }
    }
}
