using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTA_Prep_Class_3___Notes
{
    class Car
    {
        // Fields 

        public uint m_Year;
        public string m_Name;
        public string m_Color;

        // Method

        public void Report()
        {
            Console.WriteLine("{0} {1} {2}", m_Year, m_Color, m_Name); // you can use escape characters here such as \n ex. "{0}\n{1}\n{2}"
        }

    }
}
