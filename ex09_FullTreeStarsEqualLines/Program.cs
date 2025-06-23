
/*The application draws a full tree, with equal characters to the row, with the character *.
The number of lines is provided by the user. User the for cycle;
Example for number 4:
 *
 * *
* * *
* * * *
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

            for (int i = 0; i <= lines; i++)
            {
               for (int space = 0;  space < lines; space++)
                {
                    Console.Write(" ");
                }
               for (int star = 0; star < i; star++)
                {
                    Console.Write("*");
                    if (star < i - 1)
                    {
                        Console.Write(" ");
                    }
                }
               Console.WriteLine();
            }
        }
    }
}