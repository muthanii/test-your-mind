/*
Question 1: Write a C# Sharp program to compute the sum of the two numerical values.
If the two values are the same, return triple their sum.

Solution: I'll make a list of numbers as an input and only multiply by 3 once they are
the same.
*/

int Question1(List<int> numbers)
{
    int number1 = numbers[0];
    int number2 = numbers[1];

    if (number1 == number2)
    {
        return (number1 + number2) * 3;
    }
    else
    {
        return number1 + number2;
    }
}

Console.WriteLine("Question 1: ");
Console.WriteLine(Question1([1, 2]));
Console.WriteLine(Question1([3, 2]));
Console.WriteLine(Question1([2, 2]));


/*

*/
int Question2(int number)
{
    if (number > 51)
    {
        int result = number - 51;
        return Math.Abs(result * 3);
    }
    else
    {
        return Math.Abs(number - 51);
    }
}

Console.WriteLine("Question 2: ");
Console.WriteLine(Question2(53));
Console.WriteLine(Question2(30));
Console.WriteLine(Question2(51));
