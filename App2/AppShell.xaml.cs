namespace App2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {

            InitializeComponent();
        }

        private void Logout(object? sender, TappedEventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}
