using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace smartstick1.Models
{
    class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
    }
}
