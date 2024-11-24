using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//suppose we have 5 employee and we need to promote those whoes experience more than 5 years or eqal

namespace ExplorreCSharrp
{


    public delegate bool IsAvailToPromoted(Employee employee);
    class UsesOfDelegate
    {
        public static bool IsPermitToPromoted(Employee employee)
        {
            if (employee.experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    public class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int experience { get; set; }


        public static void printPromotedList(List<Employee> employeelist)
        {
            foreach (Employee employee in employeelist)
            {
                if (employee.experience >= 5)
                {
                    Console.WriteLine("{0} is Promoted", employee.Name);
                }
            }
        }
        public static void printPromotedList(List<Employee> employeelist, IsAvailToPromoted isPromoted)
        {
            foreach (Employee employee in employeelist)
            {
                if (isPromoted(employee))
                {
                    Console.WriteLine("{0} is Promoted", employee.Name);
                }
            }
        }

    }
}
