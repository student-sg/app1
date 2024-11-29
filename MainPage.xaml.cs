using Microsoft.Maui.Controls;
using System;
namespace smartstick1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new login1());
        }
        void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new dashboard1());
        }

    }

}
