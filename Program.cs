using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                char yes;

                string myName;
                Console.Write("Please type your name: ");
                myName = Console.ReadLine();

                int input;
                Console.Write("{0} please enter an integer between 1 and 100: ", myName);

                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("{0} your entry is invalid as it is not a number, please enter an integer.", myName);
                    continue;
                }
                if (input > 100)
                {
                    Console.WriteLine("{0} your entry is invalid as the number {1} entered is greater than 100!", myName, input);
                }
                else if (input < 1)
                {
                    Console.WriteLine("{0} your entry is invalid as the number {1} entered is less than 1!", myName, input);
                }
                else if (input % 2 != 0 && input >= 1 && input <= 100)
                {
                    Console.WriteLine("{0} your entry of {1} is an odd number.", myName, input);
                }
                else if (input % 2 == 0 && input >= 2 && input <= 25)
                {
                    Console.WriteLine("{0} your entry of {1} is an even numberg greater than or equal to 2 and less than 25.", myName, input);
                }
                else if (input % 2 == 0 && input >= 26 && input <= 60)
                {
                    Console.WriteLine("{0} your entry of {1} is an even number between 26 and 60.", myName, input);
                }
                else if (input % 2 == 0 && input < 100 && input > 60)
                {
                    Console.WriteLine("{0} your entry of {1} is an even number greater than 60.", myName, input);
                }
                if (input % 2 != 0 && input < 100 && input > 60)
                {
                    Console.WriteLine("{0} your entry of {1} is an odd number greater than 60.", myName, input);
                }



                Console.WriteLine("Continue? (y/n)");
                yes = char.Parse(Console.ReadLine());

                if (yes == 'y')
                {
                    continue;
                }
                else if (yes != 'y')
                {
                    return;
                }

               


            } while (true);

        }
    }
}