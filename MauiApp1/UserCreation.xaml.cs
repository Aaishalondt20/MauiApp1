namespace MauiApp1;

public partial class UserCreation : ContentPage
{
	public UserCreation()
	{
		InitializeComponent();

	}

    private void Proceed_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}
