using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Pair
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Customer cust1 = new Customer()
              {
                  ID = 101,
                  Name = "Usama",
                  Salary = 0
              };

            Customer cust2 = new Customer()
            {
                ID = 102,
                Name = "Umer",
                Salary = 3000
            };

            Customer cust3 = new Customer()
            {
                ID = 103,
                Name = "Taha",
                Salary = 15000
            };

            Dictionary<int, Customer> CustomerDictionary = new Dictionary<int, Customer>();
            CustomerDictionary.Add(cust1.ID, cust1);
            CustomerDictionary.Add(cust2.ID, cust2);
            CustomerDictionary.Add(cust3.ID, cust3);

            Customer cust102 = CustomerDictionary[102];

            foreach (KeyValuePair<int, Customer> CustomerKeyValuePair in CustomerDictionary)
            {
                Console.WriteLine("Key={0}",CustomerKeyValuePair.Key);
                Customer cust = CustomerKeyValuePair.Value;
                Console.WriteLine("ID={0} ,Name={1} ,Salary={2} ",cust.ID,cust.Name,cust.Salary);
                Console.WriteLine("--------------------");
            }
            Console.ReadLine();
        }
    }

    
}
