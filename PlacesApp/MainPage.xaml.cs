using PlacesApp.ViewModels;

namespace PlacesApp;

public partial class MainPage : ContentPage
{
	private readonly MainPageViewModel _viewModel;

	public MainPage(MainPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = _viewModel = viewModel;
	}
}

