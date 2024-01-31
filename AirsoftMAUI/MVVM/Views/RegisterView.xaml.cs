using AirsoftMAUI.MVVM.ViewModels;

namespace AirsoftMAUI.MVVM.Views;

public partial class RegisterView : ContentPage
{
	RegisterViewModel _viewModel;
	public RegisterView(RegisterViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
	}
}