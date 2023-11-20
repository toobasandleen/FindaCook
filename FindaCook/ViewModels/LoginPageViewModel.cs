using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FindaCook.Services;

namespace LoginApp.Maui.ViewModels
{
    public partial class LoginPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string email;

        [ObservableProperty]
        private string password;
        readonly ILoginRespository loginService = new LoginService();

        [RelayCommand]
        public async void SignIn()
        {
            
        }

    }
}
