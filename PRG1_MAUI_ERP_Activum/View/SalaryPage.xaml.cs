namespace PRG1_MAUI_ERP_Activum.View;

public partial class SalaryPage : ContentPage
{
	public SalaryPage()
	{
		InitializeComponent();
	}


private void OnCalculateSalaryClicked(object sender, EventArgs e)
	{
		bool isSalesValid = double.TryParse(SalesEntry.Text, out double sales);
		bool isMonthsValid = int.TryParse(MonthsEntry.Text, out int months);

		if (isSalesValid && isMonthsValid && months <= 11) {
			double grundlon = 26000;
			double provision = sales * 0.12;
			double manadslon = grundlon + provision;

			double totalIntjanat = manadslon * months;
			double semesterlon = totalIntjanat * 0.12;

			double bruttoTotal = manadslon + semesterlon;
			double skatt = bruttoTotal * 0.32;
			double netto = bruttoTotal - skatt;

			ResultLabel.Text =
				$"Grundlön: {grundlon:C0}\n" +
				$"Provision: {provision:C0}\n" +
				$"Semesterlön ({months} mån): {semesterlon:C0}\n" +
				$"Brutto Totalt: {bruttoTotal:C0}\n" +
				$"Skatt (32%): -{skatt:C0}\n\n" +
				$"UTBETALNING: {netto:C0}";

		}
		else
		{
			ResultLabel.Text = "Fyll i giltliga siffror, max 11 månader för semesterlön";
		}
	}
} 