using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{

    public class Student
    {
        private int id;
        private string name;
        private int referValue = 200;
     public int Id
        { 
          set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Id cannot be negative");
                }
                else
                {
                    id = value;
                }

            }
            get
            {
                return id;
            }
        }

        public string Name
        {
            set {
              if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null");
                }
                else
                {
                    this.name = value;
                }
            }

            get
            {
                return name;
            }
        }

        //readOnly Property

        public int ReferValue
        {
            get;
        }

        //auto generated private field with the property

        public string Email { get; set; }
 

        
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            student.Name = "Test";
            student.Email = "nazmulhs030@gmail.com";
            student.Id= 1;
         Console.WriteLine("Name : {0} && Id:{1} && email : {1}",student.Name,student.Id,student.Email);

            Console.ReadLine();
        }
    }
}
