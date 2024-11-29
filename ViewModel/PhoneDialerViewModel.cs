using smartstick1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using smartstick1.Data;
using smartstick1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;
using smartstick1.Data;

namespace smartstick1.ViewModel
{
    public partial class PhoneDialerViewModel : ObservableObject
    {
        private string phoneNumber;

        [ObservableProperty]
        private DateTime callTime;

        public Command CalleNumberCommand { get; }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetProperty(ref phoneNumber, value);
        }

        public PhoneDialerViewModel()
        {
            CalleNumberCommand = new Command(OnCallNumber);
            CallTime = DateTime.Now;
        }

        void OnCallNumber()
        {
            voicecallServices.CallNumberPhoneAsync(PhoneNumber);
        }

        public ObservableCollection<CallDetail> CallDetails { get; } = new();

        public async Task LoadCallDetailsAsync()
        {
            try
            {
                using (var dbContext = new AppDbContext())
                {
                    var callDetails = await dbContext.CallDetails.ToListAsync();
                    CallDetails.Clear();
                    foreach (var detail in callDetails)
                    {
                        CallDetails.Add(detail);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading call details: {ex.Message}");
            }
        }
    }
}
