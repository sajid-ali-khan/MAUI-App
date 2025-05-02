namespace App2;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void GoToMain(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
        AppShell.Current.GoToAsync("//MainPage");
    }

    private void GoToRegestration(object? sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new RegistrationPage();
    }

    private void ForgotPasswordClicked(object? sender, TappedEventArgs e)
    {
        //do nothing
    }
}