namespace smartstick1;

public partial class forgotpassword1 : ContentPage
{
    public forgotpassword1()
    {
        InitializeComponent();
    }
    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 1)
        {
            Navigation.PopAsync();
        }
    }
    async void OnResetPasswordButtonClicked(object sender, EventArgs e)
    {
        bool isEmailSent = SendPasswordResetEmail(emailEntry.Text);

        if (isEmailSent)
        {
            await DisplayAlert("Password Reset", "A password reset link has been sent to your email.", "OK");
            await Navigation.PushAsync(new login1());
        }
        else
        {
            await DisplayAlert("Reset Failed", "An error occurred while sending the reset email.", "OK");
        }
    }

    bool SendPasswordResetEmail(string email)
    {
        // Placeholder for actual email sending logic
        // This could involve calling a web service to send the reset email
        return true; // Assuming the email is always sent successfully
    }
}