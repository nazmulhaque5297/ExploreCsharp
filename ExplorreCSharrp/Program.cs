using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer[] customers = new Customer[3];
            customers[0] = new Customer
            {
                Name = "Test",
                genderInit = GenderWithInitializeValue.Unknown
            };
            customers[1] = new Customer
            {
                Name = "Test",
                genderCustomize = GenderWithCustomizeValue.Unknown
            };

            customers[2] = new Customer
            {
                Name = "Nazmul",
                genderCustomize = GenderWithCustomizeValue.Male,
                genderInit = GenderWithInitializeValue.Male
            };

            int[] valueOfGenderWithInitializeValue = Customer.GenderWithInitializeValue();
            int[] valueOfWithInitializeValue = Customer.getGenderWithCustomizeValue();
            foreach (Customer customer in customers)
            {
                Console.WriteLine("The Name of the Customer is : {0},Gender is :{1}",customer.Name,customer.genderInit);

            }

            foreach (int value in valueOfGenderWithInitializeValue) {
                Console.WriteLine(value);
            }

            foreach (int value in valueOfWithInitializeValue)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
