using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartstick1.Models
{
    public class CallDetail
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CallTime { get; set; }
        public string CallStatus { get; set; }
    }
}
