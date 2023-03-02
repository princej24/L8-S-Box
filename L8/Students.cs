using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8
{
    public class Students
    {

        public string FirstName;
        public string LastName;
        public int CSIgrade;
        public int GenEdgrade;
        public Students(string firstName, string lastName, int cSIgrade, int genEdgrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIgrade = cSIgrade;
            GenEdgrade = genEdgrade;
        }
    }
}
