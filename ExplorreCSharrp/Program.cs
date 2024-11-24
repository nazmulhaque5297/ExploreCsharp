using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    // ho here i introduce a helloPrinterDelegiate Where it is a void type cast and
    // it can point a function which return type is void and can take string as a parameteer 
    public delegate void helloPrinterDeligate(string ms);
    internal class Program
    {

        
        static void Main(string[] args)
        {
            /*
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
           



            Polymorphism pm = new Polymorphism();
            pm.DisplayEmployeeName();

        

            Properties p = new Properties();
            p.ViewProPerties();

                */


            Deligate de = new Deligate();
            helloPrinterDeligate d = new helloPrinterDeligate(de.helloPrinter);
            d("hi this is nazmul call from a delegeate");

            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { Name = "Nazmul", Age = 25, experience = 5 });
            empList.Add(new Employee() { Name = "Sahadat", Age = 25, experience = 5 });
            empList.Add(new Employee() { Name = "Waiji", Age = 25, experience = 5 });
            empList.Add(new Employee() { Name = "Sadman", Age = 25, experience = 6 });
            empList.Add(new Employee() { Name = "Rakib", Age = 25, experience = 4 });
            empList.Add(new Employee() { Name = "Taukir", Age = 25, experience = 3 });

            //Employee.printPromotedList(empList);

            // Here Employee.printPromotedList(empList); is call without delegate So if we want to make another 
            //condition then we need to change the codition under the printPromotedList



            // here the examle of delegates 

            IsAvailToPromoted isReadyToPromote = new IsAvailToPromoted(UsesOfDelegate.IsPermitToPromoted);
            Employee.printPromotedList(empList, isReadyToPromote);

            Console.ReadLine();
        }
    }
}
