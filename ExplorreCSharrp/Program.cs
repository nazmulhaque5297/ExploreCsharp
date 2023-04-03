using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    public delegate void HelloFunctionDelegate(string message);


    // this delegates are used for multitask deligates

    public delegate void SampleDelegate();
    public delegate int SampleIntDelegate();
    public delegate void SampleParamDelegate(out int number);
    internal class Program
    {
        static void Main(string[] args)
        {


            // Explain List

            ExplainList explainList= new ExplainList();
            explainList.findEvenNumber();
           
            // use of Delegate 

            HelloFunctionDelegate del = new HelloFunctionDelegate(ExplainDelegate.HelloMessage);
            del("Hi this is a call from Delegate");


            //Use Of Delegate 2

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Id=101,Name="Nazmul",salary=35000,experience=2});
            employees.Add(new Employee() { Id=101,Name="Sahinur",salary=45000,experience=3});
            employees.Add(new Employee() { Id=101,Name="Mostoba",salary=30000,experience=1});
            employees.Add(new Employee() { Id=101,Name="Aminur",salary=700000,experience=5});

            Employee.PromoteEmployee(employees, emp => emp.experience >= 5);


            // explame of Multicast Deligate 

            SampleDelegate multicastVoid = new SampleDelegate(MultiCastDeligate.sampleMethodOne);
            multicastVoid += MultiCastDeligate.sampleMethodTwo;
            multicastVoid();

            SampleIntDelegate multiCastInt = new SampleIntDelegate(MultiCastDeligate.sampleIntMethodOne);
            multiCastInt += MultiCastDeligate.sampleIntMethodTwo;
            int valueInt = multiCastInt();

            int param = -1;

            SampleParamDelegate multiCastParam = new SampleParamDelegate(MultiCastDeligate.sampleParamMethodOne);
            multiCastParam += MultiCastDeligate.sampleParamMethodTwo;
            multiCastParam(out param);

            Console.WriteLine("The MultiCasting Value Of the frame is {0}", param);






        Console.ReadLine();
        }
    }
}
