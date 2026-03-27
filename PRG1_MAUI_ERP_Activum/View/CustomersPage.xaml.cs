using PRG1_MAUI_ERP_Activum.ViewModels;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class CustomersPage : ContentPage
{
	private CustomerViewModel _viewModel;
	public CustomersPage(CustomerViewModel viewModel)
	{
		InitializeComponent();

		_viewModel = viewModel;

		BindingContext = _viewModel;
	}

	private void OnsearchTextChanged(object sender, TextChangedEventArgs e)
	{
		_viewModel.SearchCustomer(e.NewTextValue);
	}
}