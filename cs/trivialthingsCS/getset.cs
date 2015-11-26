using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trivialthingsCS
{
    public class BaseClass
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    public class DerivedClass : BaseClass
    {
        private string name;
        public new string Name   // Notice the use of the new modifier
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
