/*The application draws a full tree, with odd numbers per row, with the character *. The
number of lines is provided by the user. User the for cycle;
Example for number 4:
 *
 ***
 *****
*******
*/

using System;
using System.Runtime.Serialization.Formatters;
namespace FullTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines for the tree:");
            int lines = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                for (int space = 0; space < lines - i; space++)
                {
                    Console.Write(" ");
                }
                for (int ast = 0; ast <= 2 * i; ast++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
