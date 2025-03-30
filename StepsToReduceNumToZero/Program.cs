Console.WriteLine(NumberOfSteps(123));

int NumberOfSteps(int num)
{
    var steps = 0;

    while (num != 0)
    {
        if (num % 2 == 1)
            num--;
        else
            num /= 2;

        steps++;
    }

    return steps;
}