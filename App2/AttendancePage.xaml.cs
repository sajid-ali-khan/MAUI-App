namespace App2;

public partial class AttendancePage : ContentPage
{
	public AttendancePage()
	{
		InitializeComponent();
	}

    private async void GoToDetails(object? sender, TappedEventArgs e)
    {
        Console.WriteLine("Called....");
        await Shell.Current.GoToAsync(nameof(AttendanceDetailPage));
    }
}