namespace smartstick1;

public partial class Registeration1 : ContentPage
{
    public Registeration1()
    {
        InitializeComponent();
    }
    async void OnRegisterButtonClicked(object sender, EventArgs e)
    {
        if (passwordEntry.Text != confirmPasswordEntry.Text)
        {
            await DisplayAlert("Registration Failed", "Passwords do not match", "OK");
            return;
        }
        if (string.IsNullOrEmpty(walkingStickIdEntry.Text))
        {
            await DisplayAlert("Registration Failed", "Walking Stick ID is required", "OK");
            return;
        }
        bool isRegistered = await RegisterUserAsync(nameEntry.Text, emailEntry.Text, passwordEntry.Text, phoneNumberEntry.Text, walkingStickIdEntry.Text);

        if (isRegistered)
        {
            await Navigation.PushAsync(new login1());
        }
        else
        {
            await DisplayAlert("Registration Failed", "An error occurred during registration", "OK");
        }
    }

    void OnLoginLinkTapped(object sender, EventArgs e)
    {
        Navigation.PushAsync(new login1());
    }

    async Task<bool> RegisterUserAsync(string name, string email, string password, string phoneNumber, string walkingStickId)
    {
        return false;
    }
    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 1)
        {
            Navigation.PopAsync();
        }
    }
}