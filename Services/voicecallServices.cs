using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using smartstick1.Data;
using smartstick1.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using smartstick1.Data;

namespace smartstick1.Services
{
    public static class voicecallServices
    {
        //public static void CallNumberPhone(string number)
        //{
        //    if (PhoneDialer.Default.IsSupported)
        //    {
        //        PhoneDialer.Default.Open(number);
        //    }
        //    else
        //    {
        //        // Handle the case where the phone dialer is not supported
        //        Console.WriteLine("Phone dialer is not supported on this device.");
        //    }
        //}
        public static async Task CallNumberPhoneAsync(string number)
        {
            var callDetail = new CallDetail
            {
                PhoneNumber = number,
                CallTime = DateTime.Now,
                CallStatus = "Completed"
            };

            if (PhoneDialer.Default.IsSupported)
            {
                try
                {
                    PhoneDialer.Default.Open(number);
                }
                catch (Exception ex)
                {
                    callDetail.CallStatus = "Failed";
                    Console.WriteLine($"Failed to make a call: {ex.Message}");
                }
            }
            else
            {
                callDetail.CallStatus = "Not Supported";
                Console.WriteLine("Phone dialer is not supported on this device.");
            }

            using (var dbContext = new AppDbContext())
            {
                dbContext.CallDetails.Add(callDetail);
                await dbContext.SaveChangesAsync();
            }
        }
    }

}
