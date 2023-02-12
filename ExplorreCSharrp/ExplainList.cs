using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    internal class ExplainList
    {
        public int _selectValue;
        public ExplainList() {
            
        }

        public List<int> listValue = new List<int> {1,2,3,4,5,6,7,8,9};
        public void add(int value)
        {
            listValue.Add(value);
        }

        public void remove(int value)
        {
            listValue.Remove(value);
        }

        public void clear()
        {
            listValue.Clear();

        }

        public int size()
        {
            return listValue.Count;
        }

        public bool isEmpty()
        {
            return listValue.Count == 0;
        }

        public bool contains(int value)
        {
            return listValue.Contains(value);
        }
       
        public int indexOf(int value)
        {
            return listValue.IndexOf(value);
        }

        public int lastIndexOf(int value)
        {
            return listValue.LastIndexOf(value);
        }

       public void findEvenNumber()
        {
            List<int> evenNumber = listValue.FindAll(x => (x % 2) == 0);
            Console.WriteLine("The even Numbers of the list is: ");
            foreach(int value in evenNumber)
            {
                Console.WriteLine(value);
            }
        }



        
    }
}
