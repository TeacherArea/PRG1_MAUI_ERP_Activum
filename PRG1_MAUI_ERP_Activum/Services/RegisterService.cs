
using PRG1_MAUI_ERP_Activum.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace PRG1_MAUI_ERP_Activum.Services
{
    public class RegisterService
    {
        private static RegisterService? _instance;
        public static RegisterService Instance => _instance ??= new RegisterService();

        public ObservableCollection<Customer> Customers { get; }

        private RegisterService()
        {
            Customers = new ObservableCollection<Customer>();

            TestData();
        }

        private void TestData()
        {
            var customer1 = new Customer("Pelle", "Svanslös", "pelle@kattstugan.se", "0707 77 00 77");
            var customer2 = new Customer("Maja", "Gräddnos", "maja@katthotel.se", "0708 88 11 22");

            Customers.Add(customer1);
            Customers.Add(customer2);
        }

        public Customer? GetCustomer(Guid id) => Customers.FirstOrDefault(c => c.Id == id);
    }
}