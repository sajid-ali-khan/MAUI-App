namespace App2;

public partial class RegistrationPage : ContentPage
{
	public RegistrationPage()
	{
		InitializeComponent();
	}

    private void GoToMain(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
        AppShell.Current.GoToAsync("//MainPage");
    }

    private void GoToLoginPage(object? sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new LoginPage();
    }
}