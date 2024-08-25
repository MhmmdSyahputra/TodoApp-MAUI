namespace TodoAppSync.Views.LoginPage;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void OnLoginButtonClick(object sender, EventArgs e)
    {
        // Mengambil nilai dari Entry
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        // Menampilkan dialog dengan username dan password
        await DisplayAlert("Login Info", $"Username: {username}\nPassword: {password}", "OK");
    }
}