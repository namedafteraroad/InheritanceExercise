using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        //fly, swim, migrate, beak
        public bool CanFly { get; set; }
        public bool CanSwim { get; set; }
        public bool Migration { get; set; }
        public string BeakType { get; set; }


    }
}
// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class


/*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */