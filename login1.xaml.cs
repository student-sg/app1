using System;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Maui.Controls;
using smartstick1.Services;
using Microsoft.Win32;


namespace smartstick1;

public partial class login1 : ContentPage
{
    public login1()
    {
        InitializeComponent();
    }
    //private void OnLoginButtonClicked(object sender, EventArgs e)
    //{
    //    string username = UsernameEntry.Text;
    //    string password = PasswordEntry.Text;

    //    if (IsValidUser(username, password))
    //    {
    //        // Navigate to the Dashboard Page (replace DashboardPage with your actual page)
    //        Navigation.PushAsync(new dashboard1xaml());
    //    }
    //    else
    //    {
    //        ErrorMessage.Text = "Invalid username or password";
    //        ErrorMessage.IsVisible = true;
    //    }
    //}
    //private bool IsValidUser(string username, string password)
    //{
    //    string connectionString = "<your_connection_string>"; // Update this with your actual connection string
    //    string query = "SELECT Password, Salt FROM Users WHERE Username = @Username";
    //    string storedHashedPassword = null;
    //    byte[] salt = null;

    //    using (SqlConnection connection = new SqlConnection(connectionString))
    //    {
    //        using (SqlCommand command = new SqlCommand(query, connection))
    //        {
    //            command.Parameters.AddWithValue("@Username", username);
    //            connection.Open();
    //            using (SqlDataReader reader = command.ExecuteReader())
    //            {
    //                if (reader.Read())
    //                {
    //                    storedHashedPassword = reader.GetString(0);
    //                    salt = (byte[])reader["Salt"];
    //                }
    //            }
    //        }
    //    }

    //    if (!string.IsNullOrEmpty(storedHashedPassword) && salt != null)
    //    {
    //        return VerifyPassword(password, storedHashedPassword, salt);
    //    }

    //    return false;
    //}

    //private string HashPassword(string password, byte[] salt = null)
    //{
    //    if (salt == null)
    //    {
    //        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
    //    }

    //    var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
    //    byte[] hash = pbkdf2.GetBytes(20);

    //    byte[] hashBytes = new byte[36];
    //    Array.Copy(salt, 0, hashBytes, 0, 16);
    //    Array.Copy(hash, 0, hashBytes, 16, 20);

    //    return Convert.ToBase64String(hashBytes);
    //}

    //private bool VerifyPassword(string enteredPassword, string hashedPassword, byte[] salt)
    //{
    //    string hashedEnteredPassword = HashPassword(enteredPassword, salt);
    //    return hashedEnteredPassword == hashedPassword;
    //}

    private async void OnRegisterTapped(object sender, EventArgs e)
    {
        // Navigate to the Registration Page (replace RegistrationPage with your actual page)
        await Navigation.PushAsync(new dashboard1());
    }

    private async void OnForgotPasswordTapped(object sender, EventArgs e)
    {
        // Handle the forgot password logic or navigation here
        await Navigation.PushAsync(new forgotpassword1());
    }
    private async void OnLoginButtonClicked(object sender, EventArgs e)
    {
        //var apiService = new ApiService();
        //var user = await apiService.LoginAsync(UsernameEntry.Text, PasswordEntry.Text);

        //if (user != null)
        //{
        //    await Navigation.PushAsync(new dashboard1());
        //}
        //else
        //{
        //    ErrorMessage.Text = "Invalid username or password";
        //    ErrorMessage.IsVisible = true;
        //}

        bool isAuthenticated = AuthenticateUser(UsernameEntry.Text, PasswordEntry.Text);

        if (isAuthenticated)
        {
            await Navigation.PushAsync(new dashboard1());
        }
        else
        {
            await DisplayAlert("Login Failed", "Invalid username or password", "OK");
        }
    }

    bool AuthenticateUser(string username, string password)
    {
        return username == "test" && password == "password";
    }
    private void OnBackButtonClicked(object sender, EventArgs e)
    {
        if (Navigation.NavigationStack.Count > 1)
        {
            Navigation.PopAsync();
        }
    }
}





