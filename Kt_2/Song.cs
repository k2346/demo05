using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kt_2
{
    class Song
    {
        public string Name { get; set; }
        public string TrackLenght { get; set; }

        public override string ToString()
        {
            return Name + " " + TrackLenght;
        }
    }
}
