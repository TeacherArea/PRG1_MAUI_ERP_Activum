using System.Collections.ObjectModel;
using System.Linq;
using System.Collections.Generic;
using PRG1_MAUI_ERP_Activum.Models;

namespace PRG1_MAUI_ERP_Activum.ViewModels
{
    public class CustomerViewModel
    {
        public ObservableCollection<Customer> Customers { get; set; }

        private List<Customer> _allCustomers;

        public CustomerViewModel()
        {
            _allCustomers = new List<Customer>();
            Customers = new ObservableCollection<Customer>();

            LoadTestData();
        }
        private void LoadTestData()
        {
            _allCustomers.Add(new Customer { FirstName = "Anna", LastName = "Andersson", Email = "anna@privat.se", PhoneNumber = "070-1112233", CustomerType = "Privat" });
            _allCustomers.Add(new Customer { FirstName = "Bertil", LastName = "Svensson", Email = "bertil@företag.se", PhoneNumber = "070-9999999", CustomerType = "Företag" });
            _allCustomers.Add(new Customer { FirstName = "Cecilia", LastName = "Karlsson", Email = "cecilia@privat.se", PhoneNumber = "070-3334455", CustomerType = "Privat" });

            UpdateVisibleList(_allCustomers);
        }

        public void AddCustomer(Customer newCustomer)
        {
            _allCustomers.Add(newCustomer);
            UpdateVisibleList(_allCustomers);
        }

        public void RemoveCustomer(Customer customerToRemove)
        {
            _allCustomers.Remove(customerToRemove);
            UpdateVisibleList(_allCustomers);
        }

        public void SearchCustomer(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
            {
                UpdateVisibleList(_allCustomers);
            }

            else
            {
                var filteredList = _allCustomers
                    .Where(c => c.FullName.ToLower().Contains(searchText.ToLower()) ||
                                    c.CustomerType.ToLower().Contains(searchText.ToLower()))
                        .ToList();

                UpdateVisibleList(filteredList);
            }
        }

    private void UpdateVisibleList(List<Customer> list)
        {
            Customers.Clear();
            foreach (var customer in list)
            {
                Customers.Add(customer);
            }

        }
    }
}
