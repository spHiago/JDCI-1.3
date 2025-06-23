/*The application draws a full tree, with odd numbers per row, with the character *. The
number of lines is provided by the user. User the for cycle;
Example for number 4:
 *
 ***
 *****
*******
*/

using System;
namespace FullTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines for the tree:");
            int lines = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            while (i <= lines)
            {
                int spaces = 0;
                while (spaces < lines - i)
                {
                    Console.Write(" ");
                    spaces++;
                }
                int astDir = 0;
                while (astDir <= 2 * i)
                {
                    Console.Write("*");
                    astDir++;
                }
                Console.WriteLine();
                i++;

            }

        }
    }
}

