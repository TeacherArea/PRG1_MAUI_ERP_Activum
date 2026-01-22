namespace PRG1_MAUI_ERP_Activum.View;

public partial class ToolsPage : ContentPage
{
	public ToolsPage()
	{
		InitializeComponent();
	}
	private async void OnCalcClicked(object sender, EventArgs e)
	{
	await Navigation.PushAsync(new CalculatorPage());
	}
    private async void OnPerDiemClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PerDiemPage());
    }
    private async void OnSalaryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SalaryPage());
    }
}

