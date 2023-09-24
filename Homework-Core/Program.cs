using Homework;

int oddNumberCount = 0;//непарні числа
int evenNumberCount = 0;//парні числа

Console.WriteLine("From");
int limit1 = NumbersExtensions.ReadLine();

Console.WriteLine("To");
int limit2 = NumbersExtensions.ReadLine();

while (limit1 <= limit2)
{
    if (NumbersExtensions.IsEven(limit1))
    {
        evenNumberCount++;
    }
    else
    {
        oddNumberCount++;

    }
    limit1++;
}
//Console.WriteLine("Кількість непарних чисел = " + oddNumberCount);
//Console.WriteLine("Кількість парних чисел = " + evenNumberCount);
Console.WriteLine("Number of odd numbers equals " + oddNumberCount);
Console.WriteLine("Number of even numbers = " + evenNumberCount);
Console.ReadLine();