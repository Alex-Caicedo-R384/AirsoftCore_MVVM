using AirsoftMAUI.MVVM.ViewModels;

namespace AirsoftMAUI.MVVM.Views;

public partial class LoginPage : ContentPage
{
	LoginUserViewModel _viewModel;
	public LoginPage(LoginUserViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
    }
}