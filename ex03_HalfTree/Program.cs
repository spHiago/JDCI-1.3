/*The application draws half a tree with the character *. The number of lines is provided by 
the user. Use the for cycle; 
Example for number 4: 
* 
** 
*** 
****
*/

Console.WriteLine("Digite o numero de espaçamento Z e Y utilizados na meia arvore:");
string input1 = Console.ReadLine();
int number = int.Parse(input1);
Console.WriteLine($"voce escolheu o numero {number}.");
int i = 1;
int j = 1;
while (i <= number)
{
    j = 1;
    while(j <= i)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}
