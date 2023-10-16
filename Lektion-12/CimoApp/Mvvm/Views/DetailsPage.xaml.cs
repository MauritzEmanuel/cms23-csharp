using CimoApp.Mvvm.ViewModels;

namespace CimoApp.Mvvm.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}