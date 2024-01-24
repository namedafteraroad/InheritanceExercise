using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //animal legs, meat, train, eyes
            //bird fly, swim, migrate, beak
            //reptile eggs, claws, noctural, venom/poison
           
            
            //BIRDS
            Bird raven = new Bird();
            raven.Legs = 2;
            raven.EatsMeat = true;
            raven.CanBeTrained = true;
            raven.EyeNumber = 2;
            raven.CanFly = true;
            raven.CanSwim = false;
            raven.Migration = false;
            raven.BeakType = "long";

            Console.WriteLine("Thinking of getting a new pet Raven? Here's some facts before you buy. ");
            Console.WriteLine($"Like most birds, a raven has {raven.Legs} legs, and {raven.EyeNumber} eyes.");
            Console.WriteLine($"The raven has a {raven.BeakType} beak ");
            Console.WriteLine($"Essitenals for bird ownership");
            Console.WriteLine($"It can swim: {raven.CanSwim}");
            Console.WriteLine($"It can fly: {raven.CanFly}");
            Console.WriteLine($"Does it eat meat: {raven.EatsMeat}");
            Console.WriteLine($"Is it trainable: {raven.CanBeTrained}");
            Console.WriteLine($"Does it need to migrate: {raven.Migration}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //REPTILES
            Reptile gator = new Reptile();
            gator.Legs = 4;
            gator.EatsMeat = true;
            gator.CanBeTrained = false;
            gator.EyeNumber = 2;
            gator.LaysEggs = true;
            gator.HasClaws = true;
            gator.IsNoctural = true;
            gator.VenomPoison = "neither";

            Console.WriteLine($"So you have an alligator in your house?");
            Console.WriteLine("Thinking of keeping it as a pet?");
            Console.WriteLine("Well, you do you, but before you make your decision, let me lay out some facts that might help");
            Console.WriteLine($"Body facts: A alligator has {gator.Legs} legs, {gator.EyeNumber} eyes");
            Console.WriteLine($"Can I train it: {gator.CanBeTrained}");
            Console.WriteLine($"Does it eat meat: {gator.EatsMeat}");
            Console.WriteLine($"Does it lay eggs: {gator.LaysEggs}");
            Console.WriteLine($"What about claws, does it have claws: {gator.HasClaws}");
            Console.WriteLine($"Does it like to hunt at night: {gator.IsNoctural}");
            Console.WriteLine($"Does it have venom or poison: {gator.VenomPoison} ");
            



            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
