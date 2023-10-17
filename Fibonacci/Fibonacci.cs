using System;

public static class Fibonacci
{
    public static List<int> Generate(int N)
    {
        List<int> sequence = new List<int>();

        if (N <= 0)
        {
            return sequence;
        }

        int a = 0, b = 1;
        sequence.Add(a);

        while (b <= N)
        {
            sequence.Add(b);

            int temp = a + b;
            a = b;
            b = temp;
        }

        return sequence;
    }
}


   

