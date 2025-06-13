/*3. The application draws half a tree with the character *. The number of lines is provided by 
the user. Use the for cycle; 
Example for number 4: 
* 
** 
*** 
**** */

//6. The application is identical to application 3, using the While cycle; 

Console.WriteLine("Por favor, digite um numero:");
int linhasMax = Convert.ToInt32(Console.ReadLine());

int linhaAtual = 0;
int i = 0;

while(linhaAtual <= linhasMax)
{
    i = 0;
    while (i <= linhaAtual)
    {
        Console.Write("*");
        i++;
    }
    Console.WriteLine();
    linhaAtual++;
}