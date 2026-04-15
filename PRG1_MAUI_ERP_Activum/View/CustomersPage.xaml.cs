using PRG1_MAUI_ERP_Activum.Model;
using PRG1_MAUI_ERP_Activum.Services;

namespace PRG1_MAUI_ERP_Activum.View
{

    public partial class CustomersPage : ContentPage
    {
        private readonly RegisterService _service = RegisterService.Instance;

        public CustomersPage()
        {
            InitializeComponent();

            CustomersCollection.ItemsSource = _service.Customers;
        }

        private void AddCustomer_Clicked(object sender, EventArgs e)
        {
            _service.Customers.Add(new Customer("", "", "", ""));
        }

        private void DeleteCustomer_Clicked(object sender, EventArgs e)
        {
            var selected = CustomersCollection.SelectedItem as Customer;
            if (selected != null)
                _service.Customers.Remove(selected);
        }

        // TODO: Lägga till en CollectionView i xaml (en InsuranceCollection), ge CustomersCollection en SelectionChange samt metod för att visa försäkringar för vald kund

        // TODO: Funktion för att updatera en redan befintlig kund
    }
}