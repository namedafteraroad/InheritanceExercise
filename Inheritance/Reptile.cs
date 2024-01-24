using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        //eggs, claws, noctural
        public bool LaysEggs { get; set; }
        public bool HasClaws { get; set; }
        public bool IsNoctural { get; set; }
        public string VenomPoison { get; set; }



    }
}
// Create a class Reptile
// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class


/*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */