namespace MauiApp1;

public partial class MxitChat : ContentPage
{
	public MxitChat()
	{
		InitializeComponent();
	}

    private void Menu_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    
    
}