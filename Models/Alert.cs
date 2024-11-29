using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartstick1.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; } = string.Empty; // Initialize with a default value
        public string Message { get; set; } = string.Empty; // Initialize with a default value
        public bool IsRead { get; set; }
    }

}
