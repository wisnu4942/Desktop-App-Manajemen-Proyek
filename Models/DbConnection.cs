using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemOperasiProyek.Models
{
    public static class DbConnection
    {
        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db.users.mdb");
        }
    }
}
