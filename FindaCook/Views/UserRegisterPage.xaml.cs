namespace FindaCook;

public partial class UserRegisterPage : ContentPage
{
	public UserRegisterPage()
	{
		InitializeComponent();
	}
    private async void NavigateToLoginPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
}