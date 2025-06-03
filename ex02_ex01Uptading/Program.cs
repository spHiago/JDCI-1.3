/*Update the application 1 so that the calculated table is based on a provided number by 
the user. User the for cycle; */



Console.WriteLine("Give me a number and i will return the table of this number:");
string input1 = Console.ReadLine();
int number = int.Parse(input1);

Console.WriteLine($"You choice the number {number}.");

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}.");
}