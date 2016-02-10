using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string SocialSecurityNum { get; set; }
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + SocialSecurityNum;
        }
    }
}
