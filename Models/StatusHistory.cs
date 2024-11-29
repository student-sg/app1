using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartstick1.Models
{
    public class StatusHistory
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Status { get; set; } = string.Empty; // Initialize with a default value
    }
}
