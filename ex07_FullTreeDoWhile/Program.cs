/*4. The application draws a full tree with the character *. The number of lines is provided by
the user. User the for cycle;
Example for number 4:
 **
 ****
 ******
*********/

/*7. The application is identical to application 4, using the Do/While cycle;*/

Console.WriteLine("Por favor, digite um numero:");
int linhas = Convert.ToInt32(Console.ReadLine());

int linhaAtual = 0;
int astEsq = 0;
int space = 0;
int astDir = 0;
do
{
    space = 0;
    astEsq = 0;
    astDir = 0;
    do
    {
        Console.Write(" ");
        space++;
    } while (space <= linhas - linhaAtual);
    do
    {
        Console.Write("*");
        astEsq++;
    } while (astEsq <= linhaAtual);
    do
    {
        Console.Write("*");
        astDir++;
    } while (astDir <= linhaAtual);
    Console.WriteLine();
    linhaAtual++;
} while (linhaAtual <= linhas);