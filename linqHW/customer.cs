using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_homework
{
    class Customer
    {
        public string CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; } 
        public string Country { get; set; }

        public Customer(string customerId, string companyName, string adress, string city, string region, string country)
        {
            CustomerId = customerId;
            CompanyName = companyName;
            Adress = adress;
            City = city;
            Region = region;
            Country = country;
        }

    }
}
