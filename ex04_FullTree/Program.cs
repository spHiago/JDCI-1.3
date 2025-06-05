/*4. The application draws a full tree with the character *. The number of lines is provided by 
the user. User the for cycle; 
Example for number 4: 
      ** **
    **** ****
  ****** *****
******** ******
*/

Console.WriteLine("Digite o numero de espaçamento Z e Y utilizados na arvore:");
string input1 = Console.ReadLine();
int number = int.Parse(input1);
Console.WriteLine($"voce escolheu o numero {number}.");
for (int linha = 1; linha < number; linha++)
{
    for (int space = 0; space < number - linha; space++)
    {
        Console.Write(" ");
    }
    for (int ast = 0; ast < linha; ast++)
    {
        Console.Write("*");
    }
    Console.Write(" ");
    for (int astDir = 0; astDir < linha; astDir++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}