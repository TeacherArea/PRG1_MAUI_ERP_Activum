
using PRG1_MAUI_ERP_Activum.Model;
using System.Collections.ObjectModel;
using System.Linq;

namespace PRG1_MAUI_ERP_Activum.Services
{
    /// <summary>
    /// Klassen är en hjälpklass för att hantera listor av kunder, försäkringar och andra data som behövs i applikationen.
    /// 
    /// Detta för att hålla all data på ett ställe (Model), göra det lättare att hantera och uppdatera listorna, samt nå dem från alla View vi önskar.
    /// Klassen är implementerad som en s.k. singleton för att säkerställa att det bara finns en instans av den i hela applikationen.
    /// 
    /// Det är här vi kommer att (i nästa branc/funktionalitet) lägga länka ihop den framtida klassen för försäkringar, så att
    /// vi kan hantera både kunder och försäkringar i samma klass.
    /// </summary>
    /// 
    public class RegisterService
    {
        private static RegisterService? _instance;
        public static RegisterService Instance => _instance ??= new RegisterService(); // denna rad garanterar att instansen är "singleton", och vi når den via namnet Instance

        public ObservableCollection<Customer> Customers { get; }

        private RegisterService()
        {
            Customers = new ObservableCollection<Customer>();

            TestData(); // ta bort
        }

        // TDOD: ta bort TestData(), och istället implementera metoder för att lägga till, ta bort och editera kunder
        private void TestData()
        {
            var customer1 = new Customer("Pelle", "Svanslös", "pelle@kattstugan.se", "0707 77 00 77");
            var customer2 = new Customer("Maja", "Gräddnos", "maja@katthotel.se", "0708 88 11 22");

            Customers.Add(customer1);
            Customers.Add(customer2);
        }

        public Customer? GetCustomer(Guid id) => Customers.FirstOrDefault(c => c.Id == id);

        //TODO länka ihop försäkringar och kunder

        // TDOD: implementera metoder för att lägga till, ta bort och editera försäkringar
    }
}