static void NumeroAmistoso(int start, int end)
{
    for (int i = start; i <= end; i++)
    {
        int sumDivisorsI = SumDivisors(i);
        if (sumDivisorsI > i && sumDivisorsI <= end)
        {
            int sumDivisorsJ = SumDivisors(sumDivisorsI);
            if (sumDivisorsJ == i)
            {
                Console.WriteLine($"Número amistoso encontrado: {i} y {sumDivisorsI}");
            }
        }
    }
}

static int SumDivisors(int num)
{
    int sum = 1; // Incluye 1 como divisor
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        {
            sum += i;
            if (i != num / i)
            {
                sum += num / i;
            }
        }
    }
    return sum;
}


NumeroAmistoso(1000, 1500);