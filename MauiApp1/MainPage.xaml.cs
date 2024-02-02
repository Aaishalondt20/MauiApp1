namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserCreation());
        }

        private void Login_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MxitChat());
        }
    }

}
