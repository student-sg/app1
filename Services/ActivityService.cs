using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartstick1.Models;

namespace smartstick1.Services
{
    public class ActivityService
    {
        private readonly List<Activity> _activities = new List<Activity>();

        public void AddActivity(int steps, double distance)
        {
            var activity = new Activity
            {
                Id = _activities.Count + 1,
                Timestamp = DateTime.Now, // Ensure you use the correct property name from Activity model
                Steps = steps,
                Distance = distance
            };
            _activities.Add(activity);
        }
        public List<Activity> GetActivityHistory()
        {
            return _activities;
        }
    }

}
