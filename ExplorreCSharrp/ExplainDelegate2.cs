using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    internal class ExplainDelegate2
    {
       


    }


   public delegate bool isPromoted(Employee empl);
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        public static void PromoteEmployee(List<Employee> employeeList, isPromoted isEligibleToPromot)
        {
            foreach(Employee emp in employeeList)
            {
                if (isEligibleToPromot(emp))
                {
                    Console.WriteLine(emp.Name + "is Promoted");
                }   

            }
        }

    }
}
