using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kt_3_zoo
{
    class Animal
    {
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    public override string ToString()
        {
            return "Species: " + Species + "," + " Animal Name: "+ Name + "," +  " Age: "  + Age + "," + " Color: " + Color;
        }
    }
}
