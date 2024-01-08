Console.WriteLine("Prime Factorization Program");

Console.Write("Enter a positive integer greater than 1: ");

var number = int.Parse(Console.ReadLine()!);

if (number > 1)
{
    var factors = GetPrimeFactors(number);

    Console.Write($"Prime factors of {number}: ");

    foreach (var factor in factors)
    {
        Console.Write(factor + " ");
    }
}
else
{
    Console.WriteLine("Invalid input.");
}

List<int> GetPrimeFactors(int n)
{
    List<int> factors = new();
    var divisor = 2;

    while (n > 1)
    {
        if (n % divisor == 0)
        {
            factors.Add(divisor);
            n /= divisor;
        }
        else
        {
            divisor++;
        }
    }

    return factors;
}
