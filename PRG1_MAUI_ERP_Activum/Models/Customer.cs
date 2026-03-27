using System;
using System.Collections.Generic;
using System.Text;

namespace PRG1_MAUI_ERP_Activum.Models
{
    public class Customer
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; } =string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string CustomerType { get; set; } = string.Empty;

        public string FullName => $"{FirstName} {LastName}";
    }
}
