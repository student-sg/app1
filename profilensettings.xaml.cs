namespace smartstick1;
using smartstick1.Views;

public partial class profilensettings : ContentPage
{
    public profilensettings()
    {
        InitializeComponent();

    }
    private async void OnMenuClicked(object sender, EventArgs e)
    {
        // Display Action Sheet for menu options
        var action = await DisplayActionSheet("Menu", "Cancel", null, "Alerts/Notifications", "Staus History", "Activity Tracking", "Location", "Voice Call", "Dashboard", "Logout");

        // Handle navigation based on the action chosen
        switch (action)
        {
            case "Alerts/Notifications":
                await Navigation.PushAsync(new alerts());
                break;
            case "Status History":
                await Navigation.PushAsync(new status());
                break;
            case "Activity Tracking":
                await Navigation.PushAsync(new activitytracking());
                break;
            case "Location":
                await Navigation.PushAsync(new location1());
                break;
            case "Voice Call":
                await Navigation.PushAsync(new voicecall1());
                break;
            case "Profile/Settings":
                await Navigation.PushAsync(new dashboard1());
                break;
            case "Logout":
                // Implement logout functionality
                break;
            case "Cancel":
                // Handle cancel action
                break;
        }
    }
}