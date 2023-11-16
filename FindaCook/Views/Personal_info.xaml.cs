using Microsoft.Maui.Controls;

namespace FindaCook;

public partial class Personal_info : ContentPage
{
    public Personal_info()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string firstName = FirstNameEntry.Text;
        string middleName = MiddleNameEntry.Text;
        string lastName = LastNameEntry.Text;
        string contactNumber = ContactEntry.Text;
        //string email = EmailEntry.Text;
        string currentAddress = CurrentAddressEntry.Text;
        string permanentAddress = PermanentAddressEntry.Text;
        bool eligibleToWork = EligibleToWorkSwitch.IsToggled;

        await Navigation.PushAsync(new QualificationPage());
    }
}
