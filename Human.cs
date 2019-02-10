using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_class_app
{
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string HairColour { get; set; }
        public double Weight { get; set; }

        public string FullName {
         get { return FirstName + "" + LastName; }
        }
    }
}
