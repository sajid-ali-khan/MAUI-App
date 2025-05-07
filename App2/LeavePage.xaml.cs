namespace App2;

public partial class LeavePage : ContentPage
{
	public LeavePage()
	{
		InitializeComponent();
	}

    private async void GoToLeaveForm(object? sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LeaveFormPage));
    }
}