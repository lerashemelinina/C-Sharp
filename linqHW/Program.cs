using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace linq_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customersList = new List<Customer>();
            string connectionString = "Data Source=DESKTOP-SV32MRQ\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

            SqlConnection sql=null;

            try
            {
                using (sql = new SqlConnection(connectionString))
                {
                    sql.Open();
                    SqlCommand querry = new SqlCommand("SELECT * FROM [dbo].[Customers]", sql);
                    SqlDataReader dataReader = querry.ExecuteReader();

                    while (dataReader.Read())
                    {
                        customersList.Add(new Customer(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(4),
                                                       dataReader.GetString(5), (dataReader.IsDBNull(6) ? "-" : dataReader.GetString(6)), dataReader.GetString(8)));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            var selectedCustomers = customersList.Where(s => s.CustomerId.Contains("A")||s.CustomerId.Contains("a"));

            foreach (var item in selectedCustomers)
            {
                Console.WriteLine($"customer id: {item.CustomerId}, company name: {item.CompanyName}, adress: {item.Adress}," +
                                  $"city: {item.City}, region: {item.Region}, country: {item.Country}");
            }

            Console.ReadKey();
        }
    }
}
