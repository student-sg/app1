using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartstick1.Models;
using System.Collections.Generic;
using System.Linq;

namespace smartstick1.Services
{
    public class AlertService
    {
        private readonly List<Alert> _alerts = new List<Alert>();

        public void AddAlert(string type, string message)
        {
            var alert = new Alert
            {
                Id = _alerts.Count + 1,
                Timestamp = DateTime.Now,
                Type = type,
                Message = message,
                IsRead = false
            };
            _alerts.Add(alert);
        }

        public List<Alert> GetAlerts()
        {
            return _alerts;
        }

        public void MarkAsRead(int alertId)
        {
            var alert = _alerts.FirstOrDefault(a => a.Id == alertId);
            if (alert != null)
            {
                alert.IsRead = true;
            }
        }
    }

}
