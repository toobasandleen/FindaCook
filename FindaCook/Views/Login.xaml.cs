namespace FindaCook;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private async void Register_Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new UserRegisterPage());
    }
}