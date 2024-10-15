using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    public class BaseEmployee
    {
        public string FN;
        public string LN;
        public virtual void GetFullName()
        {
            Console.WriteLine(FN + " " + LN);
        }
    }

    public class FullTimeEmployee : BaseEmployee {
        public override void GetFullName()
        {
            Console.WriteLine(FN + " " + LN + " Is a full time Employee ");
        }
    }
    public class PartTimeEmployee : BaseEmployee
    {
        // use new keyword for Method Hindding 
        // but in base class we use virtual to overdire the method inside the child class which is polymorphism

        public override void GetFullName()
        {
            Console.WriteLine(FN + " " + LN + " Is a part time Employee ");
        }

    }


    class Polymorphism
    {
        public void DisplayEmployeeName()
        {
            // Create an instance of FullTimeEmployee
            FullTimeEmployee f1 = new FullTimeEmployee();

            // Assign values to the fields
            f1.FN = "Nazmul";
            f1.LN = "Haque";

            // Call the method to print the full name
            f1.GetFullName();
            // Create an instance of FullTimeEmployee
            PartTimeEmployee p1 = new PartTimeEmployee();

            // Assign values to the fields
            p1.FN = "Nazmul";
            p1.LN = "Haque";

            // Call the method to print the full name
            p1.GetFullName();

          

            ((BaseEmployee)p1).GetFullName();
            //in method hidding its shows us the parent class GetFullName method to shows the value without hyphen bbut for method overding it shows the 
            // value of p1 or child class 
        }

    }
}
