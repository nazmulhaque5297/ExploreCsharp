﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* suppose we needs to create a student class where id,name and pass mark will be the field of the class but id coud not be - and name can not be null 
 * and passmark will not be write able
 */

namespace ExplorreCSharrp
{
    public class StudentWithoutProperties
    {
        private int _id; 
        private String _name;
        private int _passmark=35;

        public void SetId(int Id)
        {
            if (Id < 0)
            {
                throw new Exception("Id Can not Be Negative Value ");
            }

            else if (Id >= 0)
            {
                this._id = Id;
            }
        }
        public int GetId ()
        {
            return this._id;
        }


        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Name Can not Null/Empty");
            }

            else 
            {
                this._name = Name;
            }
        }
        public string GetName()
        {
            return this._name;
        }

        public int GetPassMark()
        {
            return this._passmark;
        }
    }
    class Properties
    {
        public void ViewProPerties()
        {
            StudentWithoutProperties swp = new StudentWithoutProperties();
            swp.SetId (101);
            swp.SetName("Nazmul Haque");
            Console.WriteLine("Id={0} Name={1} passMark={2}", swp.GetId(), swp.GetName(), swp.GetPassMark());
        }


    }
}
