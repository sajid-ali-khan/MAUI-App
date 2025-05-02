namespace App2;

public partial class AttendanceDetailPage : ContentPage
{
	public AttendanceDetailPage()
	{
		InitializeComponent();
	}

    private void ChangeColor(object? sender, TappedEventArgs e)
    {
        if (sender is TapGestureRecognizer tap && tap.Parent is HorizontalStackLayout layout)
        {
            layout.BackgroundColor = layout.BackgroundColor == Colors.White
                ? Colors.LightGray
                : Colors.White;
        }
    }
}