using AirsoftMAUI.MVVM.Models;
using AirsoftMAUI.MVVM.ViewModels;

namespace AirsoftMAUI.MVVM.Views;

public partial class PerfilView : ContentPage
{
	PerfilViewModel _viewModel;
	public PerfilView(PerfilViewModel viewModel)
	{
		InitializeComponent();
		_viewModel = viewModel;
		BindingContext = _viewModel;
		
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
		await _viewModel.UpdateUser();
    }
}