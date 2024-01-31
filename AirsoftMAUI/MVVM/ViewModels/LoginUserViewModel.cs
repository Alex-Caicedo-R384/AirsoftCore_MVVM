using AirsoftMAUI.MVVM.Views;
using AirsoftMAUI.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirsoftMAUI.MVVM.ViewModels
{
    public partial class LoginUserViewModel : BaseViewModel
    {
        AuthService _authService;
        [ObservableProperty]
        string nombre;
        [ObservableProperty]
        string password;

        public LoginUserViewModel(AuthService authService)
        {
            _authService = authService;

        }

        [ICommand]
        async Task LoginAsync()
        {
            if(Password is null)
            {
                await Shell.Current.DisplayAlert("Error", "Ingresa un valor en contraseña", "Ok");
                return;
            }
            if (Nombre is null)
            {
                await Shell.Current.DisplayAlert("Error", "Ingresa un valor en nombre", "Ok");
                return;
            }
            await _authService.Login(Nombre,Password);

        }

        [ICommand]
        async Task GoToRegisterAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(RegisterView)}");
        }

    }
}
