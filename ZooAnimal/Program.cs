using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooAnimal
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Elephant lusinda = new Elephant() { Name = "Lusinda", EarSize = 33 };
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lusinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed "+ input);
                
                if (input ==1) 
                {
                    Console.WriteLine("Calling Lloyd.WhoAmi()");
                    lloyd.WhoAml();
                }
                else if (input == 2)
                {
                    Console.WriteLine("Calling Lusinda.WhoAmi()");
                    lusinda.WhoAml();
                }
                else if (input == 3)
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lusinda;
                    lusinda = holder;
                    Console.WriteLine("References have been swapped ");
                }
                else return;
                Console.WriteLine();

            }
        }
    }
}
