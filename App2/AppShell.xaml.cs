using Routing = Microsoft.Maui.Controls.Routing;

namespace App2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AttendanceDetailPage), typeof(AttendanceDetailPage));
        }

        private void Logout(object? sender, TappedEventArgs e)
        {
            Application.Current.MainPage = new LoginPage();
        }
    }
}
