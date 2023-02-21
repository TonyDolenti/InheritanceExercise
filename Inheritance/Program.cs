using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE/Create a class Animal
            // DONE/give this class 4 members that all Animals have in common


            // DONE/Create a class Bird
            // DONE/give this class 4 members that are specific to Bird
            // DONE/Set this class to inherit from your Animal Class

            // DONE/Create a class Reptile
            // DONE/give this class 4 members that are specific to Reptile
            // DONE/Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  DONE/give values to your members using the object of your Bird class
             *  
             * DONE/Creatively display the class member values 
             */

            Bird penguin = new Bird();
            penguin.CanFly = false;
            penguin.LengthInInches = 17;
            penguin.PredatorOrScavenger = "predator";
            penguin.Color = "white and black";
            Console.WriteLine($"The Penguin is a bird that is {penguin.LengthInInches} inches long.");
            Console.WriteLine($"It is a {penguin.PredatorOrScavenger} and is {penguin.Color}. The penguin can fly? {penguin.CanFly}");
            Console.WriteLine("Penguins cannot fly.");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("----------------------");
            Reptile snake = new Reptile();
            snake.CanRegenTail = false;
            snake.LandOrWater = "mostly land";
            snake.LocatedIn = "south america";
            snake.Color = "green";
            Console.WriteLine($"Snakes are reptiles found on {snake.LandOrWater} in {snake.LocatedIn}, and are usually {snake.Color}.");
            Console.WriteLine($"Snakes can grow new tails if they lose them. {snake.CanRegenTail}. Snakes cannot regenerate their tails.");
        }
    }
}
