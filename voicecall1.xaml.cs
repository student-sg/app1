using smartstick1.ViewModel;
using smartstick1.Views;
namespace smartstick1;

public partial class voicecall1 : ContentPage
{
    private readonly PhoneDialerViewModel _viewModel;
    public voicecall1()
    {
        InitializeComponent();
        _viewModel = new PhoneDialerViewModel();
        BindingContext = _viewModel;
    }
    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void OnMenuClicked(object sender, EventArgs e)
    {
        // Display Action Sheet for menu options
        var action = await DisplayActionSheet("Menu", "Cancel", null, "Alerts/Notifications", "Staus History", "Activity Tracking", "Location", "Dashboard", "Profile/Settings", "Logout");

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
            case "Dashboard":
                await Navigation.PushAsync(new dashboard1());
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
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.LoadCallDetailsAsync();
    }
}
