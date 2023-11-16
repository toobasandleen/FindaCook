using CommunityToolkit.Mvvm.ComponentModel;

namespace LoginApp.Maui.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;
    }
}
