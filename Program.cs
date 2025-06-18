/*
Question 1: Write a C# Sharp program to compute the sum of the two numerical values.
If the two values are the same, return triple their sum.

Solution: I'll make a list of numbers as an input and only multiply by 3 once they are
the same.
*/

int Question1a(List<int> numbers)
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

Console.WriteLine("Question 1a: ");
Console.WriteLine(Question1a([1, 2]));
Console.WriteLine(Question1a([3, 2]));
Console.WriteLine(Question1a([2, 2]));


/*
Question 2: Write a C# Sharp program to get the absolute difference between n and 51.
If n is broader than 51 return triple the absolute difference.

Solution: Again I'll do the same as the previous question.
*/

int Question2a(int number)
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

Console.WriteLine("Question 2a: ");
Console.WriteLine(Question2a(53));
Console.WriteLine(Question2a(51));
Console.WriteLine(Question2a(30));

/*
Question 3: Write a C# Sharp program to check two given integers, and return true if
one of them is 30 or if their sum is 30.

Solution: We have multiple conditions for this one.
*/
bool Question3a(List<int> numbers)
{
    int number1 = numbers[0];
    int number2 = numbers[1];

    if (number1 == 30 || number2 == 30)
    {
        return true;
    }
    else if (number1 + number2 == 30)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Question 3a: ");
Console.WriteLine(Question3a([30, 0]));
Console.WriteLine(Question3a([25, 5]));
Console.WriteLine(Question3a([20, 30]));
Console.WriteLine(Question3a([20, 25]));
