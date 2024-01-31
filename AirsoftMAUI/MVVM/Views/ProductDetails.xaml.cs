using AirsoftMAUI.MVVM.ViewModels;

namespace AirsoftMAUI.MVVM.Views;


public partial class ProductDetails : ContentPage
{
    ProductDetailViewModel _viewModel;
    public ProductDetails(ProductDetailViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.GetProductoAsync();
    }

   
}