namespace smartstick1.Views;
using smartstick1.Models;
using smartstick1.Services;

public partial class status : ContentPage
{
    private readonly StatusHistoryService _statusHistoryService;
    public status()
    {
        InitializeComponent();
        _statusHistoryService = new StatusHistoryService();
        StatusHistoryListView.ItemsSource = _statusHistoryService.GetStatusHistory();
    }
    private async void OnMenuClicked(object sender, EventArgs e)
    {
        // Display Action Sheet for menu options
        var action = await DisplayActionSheet("Menu", "Cancel", null, "Alerts/Notifications", "Dashboard", "Activity Tracking", "Location", "Voice Call", "Profile/Settings", "Logout");

        // Handle navigation based on the action chosen
        switch (action)
        {
            case "Alerts/Notifications":
                await Navigation.PushAsync(new alerts());
                break;
            case "Status History":
                await Navigation.PushAsync(new dashboard1());
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
                await Navigation.PushAsync(new profilensettings());
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