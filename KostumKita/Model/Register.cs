using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KostumKita.Model
{
    internal class Register
    {
        
        public int user_ID { get; set; }
        public string username { get; set; }
        public DateTime tanggal_lahir { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    }
}
