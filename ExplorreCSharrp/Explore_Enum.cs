using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplorreCSharrp
{
    public enum GenderWithInitializeValue
    {
        Unknown,
        Male,
        Female
    }

    public enum GenderWithCustomizeValue
    {
        Unknown = 1,
        Male = 23,
        Female = 55
    }

    public class Customer
    {
        public string Name { get; set; }
        public GenderWithInitializeValue genderInit { get; set; }
        public GenderWithCustomizeValue genderCustomize { get; set; }

        public static int [] getGenderWithCustomizeValue()
        {
            return (int[])Enum.GetValues( typeof(GenderWithCustomizeValue));
        }

        public static int[] GenderWithInitializeValue()
        {
            return (int[])Enum.GetValues(typeof(GenderWithInitializeValue));
        }
    }
}
