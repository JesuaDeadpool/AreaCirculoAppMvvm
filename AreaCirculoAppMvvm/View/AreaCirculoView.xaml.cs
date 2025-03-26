using AreaCirculoAppMvvm.ViewModel;

namespace AreaCirculoAppMvvm.View;

public partial class AreaCirculoView : ContentPage
{

	AreaCirculoViewModel viewModel; 
	public AreaCirculoView()
	{
		InitializeComponent(); 
		viewModel = new AreaCirculoViewModel();
		BindingContext = viewModel; 
	}
}