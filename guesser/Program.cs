using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pizza game");
            Console.WriteLine("");
            Console.WriteLine("Try to guess the pizzas secret ingredient!");

            /* TO DO: here is where you add your code! */
            for (int i = 11; i > MaxTrials; i--)
			{
                switch(Console.ReadLine())
                {
                        case "pineapple":
                            Console.WriteLine("YIZZ you fount ta rigt ingridiint");
                            Console.ReadLine();
                            return;
                        default:
                            Console.WriteLine("NO NO NO, dat is nat ta rigt ingridiint! " + (i-2) + " tris lift!");
                            break;
                }
                if (i==2)
                {
                    Console.WriteLine("OH NOOO! the Pizzaria is aut of ingridiintz!");
                    
                }
		    }         
        }
    }
}
