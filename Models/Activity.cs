using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartstick1.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string ActivityType { get; set; } = string.Empty; // Initialize with a default value
        public double Distance { get; set; }
        public int Steps { get; set; }
    }

}
