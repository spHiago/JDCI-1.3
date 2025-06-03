/*1. The application receives a number and returns the table of 5. User the for cycle;
5 X 1 = 5
5 X 2 = 10
5 X 3 = 15
5 X 4 = 20
5 X 5 = 25
5 X 6 = 30
5 X 7 = 35
5 X 8 = 40
5 X 9 = 45
5 X 10 = 50*/

Console.WriteLine("Give me a number and i will return it multiplicated by 5:");
string input1 = Console.ReadLine();
int number = int.Parse(input1);

Console.WriteLine($"You choice the number {number}.");

for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{number} x {i} = {number * i}.");
}

