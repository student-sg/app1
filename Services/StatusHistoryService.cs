using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartstick1.Models;

namespace smartstick1.Services
{
    public class StatusHistoryService
    {
        private readonly List<StatusHistory> _statusHistories = new List<StatusHistory>();

        public void AddStatusHistory(string status)
        {
            var statusHistory = new StatusHistory
            {
                Id = _statusHistories.Count + 1,
                Timestamp = DateTime.Now,
                Status = status
            };
            _statusHistories.Add(statusHistory);
        }

        public List<StatusHistory> GetStatusHistory()
        {
            return _statusHistories;
        }
    }

}
