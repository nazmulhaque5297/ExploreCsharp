using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    public class BaseEmployee
    {
        public string firstName;
        public string lastName; 
        public void GetFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : BaseEmployee { }
    public class PartTimeEmployee : BaseEmployee {

        // now i want to create the  GetFullName with hyphene in last to recognize the parttime employee .
        // use new keyword to avoid the error 

        public new void GetFullName()
        {
            Console.WriteLine(firstName + " " + lastName+ "- ");
        }

    }

    public class MethodHidding
    {
        public void DisplayEmployeeName()
        {
            // Create an instance of FullTimeEmployee
            FullTimeEmployee f1 = new FullTimeEmployee();

            // Assign values to the fields
            f1.firstName = "Nazmul";
            f1.lastName = "Haque";

            // Call the method to print the full name
            f1.GetFullName();
            // Create an instance of FullTimeEmployee
            PartTimeEmployee p1 = new PartTimeEmployee();

            // Assign values to the fields
            p1.firstName = "Nazmul";
            p1.lastName = "Haque";

            // Call the method to print the full name
            p1.GetFullName();

            //to invoke the parent class hiding method 

            ((BaseEmployee)p1).GetFullName();
        }



    }
}
