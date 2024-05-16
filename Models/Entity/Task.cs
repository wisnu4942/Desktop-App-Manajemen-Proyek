using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public int ProjectId { get; set; }
        public int UserId { get; set; }
        public string TaskNama { get; set; }        
        public string TaskStatus { get; set; }
        public DateTime TaskDeadline { get; set; }
    }
}
