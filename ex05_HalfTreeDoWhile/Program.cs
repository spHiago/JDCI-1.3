/*3. The application draws half a tree with the character *. The number of lines is provided by 
the user. Use the for cycle; 
Example for number 4: 
* 
** 
*** 
****
*/

//5. The application is identical to application 3, using the Do/While cycle;

Console.WriteLine("Por favor, digite um numero:");
int linha = Convert.ToInt32(Console.ReadLine());

int linhaAtual = 0;
int i = 0;

do
{
    i = 0;
    do
    {
        Console.Write("*");
        i++;
    } while (i <= linhaAtual);
    Console.WriteLine();
    linhaAtual++;
} while (linhaAtual < linha);