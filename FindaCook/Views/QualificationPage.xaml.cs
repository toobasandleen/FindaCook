namespace FindaCook;

public partial class QualificationPage : ContentPage
{
	public QualificationPage()
	{
		InitializeComponent();
	}
    private void OnYesClicked(object sender, EventArgs e)
    {
        QualificationDetails.IsVisible = true;
    }

    private async void OnNextClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new professional_info());
    }

    private async void OnNoClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new professional_info());

    }
}