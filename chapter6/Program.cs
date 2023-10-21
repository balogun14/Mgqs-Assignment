/*
Solution To Chapter6
*/


class Chapter6
{
    public static void Main()
    {
        /*
        1.Write a program that prints on the console the numbers from 1 to N.
        The number N should be read from the standard input.
        */
        // Question1();
        /*
        2.Write a program that prints on the console the numbers from 1 to N,
        which are not divisible by 3 and 7 simultaneously. The number N
        should be read from the standard input.
        */
        // Question2();
        // Question3();
        /*
        4.Write a program that prints all possible cards from a standard deck
        of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
        */
        // Question4();
        /*
            5.Write a program that reads from the console number N and print the sum
            of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,
            13, 21, 34, 55, 89, 144, 233, 377, …
            */
        // Console.Write("Enter your n: ");
        // long n = long.Parse(Console.ReadLine()!);
        // long result = Question5(n);
        // Console.WriteLine(result);
        // Question6();
        /*
        7.Write a program that calculates N!*K!/(N-K)! for given N and K
        (1<K<N).
        */
        // Question7();
        // Question8();
        // Question9();
        // Question10();
        // Question11();
        // Question12();
        // Question13();
        Question14();
        // Question15();
        // Question16();
        // Question17();
        /*

18. * Write a program that for a given number n, outputs a matrix in the
form of a spiral:
        */
        int y = 4;
        var n = GenerateSpiralMatrix(y);
        for (int i = 0; i < y; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(n[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static int[,] GenerateSpiralMatrix(int n)
    {
        int[,] matrix = new int[n, n];

        int value = 1;
        int rowStart = 0, rowEnd = n - 1;
        int colStart = 0, colEnd = n - 1;

        while (value <= n * n)
        {
            // Traverse right
            for (int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = value++;
            }
            rowStart++;

            // Traverse down
            for (int i = rowStart; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = value++;
            }
            colEnd--;

            // Traverse left
            for (int i = colEnd; i >= colStart; i--)
            {
                matrix[rowEnd, i] = value++;
            }
            rowEnd--;

            // Traverse up
            for (int i = rowEnd; i >= rowStart; i--)
            {
                matrix[i, colStart] = value++;
            }
            colStart++;
        }

        return matrix;
    }

    private static void Question17()
    {
        Console.WriteLine("This program looks for the gdg using Euclid's Algorithm");
        Console.Write("Enter your first number: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter your second number: ");
        int b = int.Parse(Console.ReadLine()!);
        int gcd = GCD(a, b);
        int lcm;

        lcm = a * b / gcd;
        Console.WriteLine($"gcd is {gcd} lcm is {lcm}");
    }
    public static int GCD(int a, int b)
    {
        int t;
        while (b != 0)
        {
            t = a;
            a = b;
            b = t % b;
        }
        return a;
    }

    private static void Question16()
    {
        Console.Write("What is your number from 1-n: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Random rand = new();
        int[] numberArray = new int[number];
        for (int i = 0; i < number; i++)
        {
            numberArray[i] = i;
        }
        for (int i = 0; i < numberArray.Length; i++)
        {
            int n = rand.Next(0, number);
            Console.WriteLine(numberArray[n]);
        }
    }

    private static void Question15()
    {
        Console.Write("What is your hexadecimal number: ");
        int number = Convert.ToInt32(Console.ReadLine()!, 16);
        Console.WriteLine(number);
    }

    private static void Question14()
    /*
    issue:84 -closed
    */
    {
        Console.Write("What is your decimal number: ");
        int number = Convert.ToInt32(Console.ReadLine()!,10);
        Console.WriteLine(number.ToString("X"));
    }


    private static void Question13()
    {
        Console.Write("What is your binary number: ");
        int number = Convert.ToInt32(Console.ReadLine()!, 2);
        Console.WriteLine(number);
    }

    private static void Question11()
    {
        Console.Write("Enter your N number: ");
        int temp = int.Parse(Console.ReadLine()!);
        // Console.Write(n);

        int count = 0;
        int divisor = 5;

        while (temp / divisor >= 1)
        {
            count += (int)Factorial(temp / divisor);
            divisor *= 5;
        }
        Console.WriteLine("The count is " + count);
    }

    private static void Question12()
    {
        Console.Write("Enter your decimal number: ");
        uint n = uint.Parse(Console.ReadLine()!);
        int numberOfBits = 8 * Convert.ToByte(n);
        for (int i = numberOfBits - 1; i >= 0; i--)
        {
            int on = (int)(n & (1 << i));
            if (on != 0)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("0");

            }
        }
    }

    private static void Question10()
    {
        /*
        Issue:86 - open
        */
        Console.Write("Enter an integer between [1...19]: ");
        int number = int.Parse(Console.ReadLine()!);
        if (number > 20 || number < 1)
        {
            Console.WriteLine("Read the instructions again");
        }
        else
        {
            for (int row = 1; row < number; row++)
            {
                for (int col = 1; col < row + number - 1; col++)
                {
                    Console.Write(col + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    private static void Question9()
    {
        Console.Write("Enter an integer between [1...n]: ");
        int num = int.Parse(Console.ReadLine()!);
        Console.Write("Enter an integer between [1...n] for x: ");
        int x = int.Parse(Console.ReadLine()!);
        double sum = 1;
        for (int i = 0; i <= num; i++)
        {
            sum += Factorial(i) / Math.Pow(x, i);
        }

    }

    private static void Question8()
    {
        // 8.In combinatorics, the Catalan numbers are calculated by the following
        // formula:
        int b;
        long k, n, y;
        double result;

        Console.Write("enter your n!");
        b = Convert.ToInt32(Console.ReadLine()!);
        n = Factorial(2 * b);
        k = Factorial(b + 1);
        y = Factorial(b);

        result = (double)(n) / ((k) * y);
        Console.WriteLine($"The result of 2{n}/({k}) * {y} = {result}");

    }

    private static void Question7()
    {

        int y, b;
        long k, n, nk;
        double result;
        Console.Write("enter your k!");
        y = Convert.ToInt32(Console.ReadLine()!);
        k = Factorial(y);

        Console.Write("enter your n!");
        b = Convert.ToInt32(Console.ReadLine()!);
        n = Factorial(b);

        nk = Factorial(b - y);
        result = (double)n * k / nk;
        Console.WriteLine($"The result of {n}!*{k!}/({b}-{y})! = {result}");
    }

    public static long Factorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }
        return number * Factorial(number - 1);
    }
    private static void Question6()
    {

        int y, b;
        long k, n;
        double result;
        Console.Write("enter your k!");
        y = Convert.ToInt32(Console.ReadLine()!);

        k = Factorial(y);

        Console.Write("enter your n!");
        b = Convert.ToInt32(Console.ReadLine()!);
        n = Factorial(b);

        result = (double)n / k;
        Console.WriteLine($"The result of {n}!/{k}! = {result}");
    }

    private static long Question5(long n)
    {
        long sum = 0;
        if (n <= 2)
        {
            return 1;
        }
        sum = Question5(n - 1) + Question5(n - 2);
        return sum;
    }

    private static void Question4()
    {
        /*
        4.Write a program that prints all possible cards from a standard deck
        of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
        */
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Queen", "King" };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                string card = rank + " of " + suit;
                Console.WriteLine(card);
            }
            Console.WriteLine("========================================================================");
        }

    }

    private static void Question3()
    {
        /*
        3.Write a program that reads from the console a series of integers and
        prints the smallest and largest of them.
        */

        Console.WriteLine("This calculates the gretest of series of integers");
        Console.Write("enter the series of number like this 12345: ");
        string a = Console.ReadLine()!;
        var array = a.ToArray();
        int highest = array[0] - '0';
        int lowest = array[0] - '0';
        foreach (var item in array)
        {
            if (item > highest)
            {
                highest = item - '0';
            }
            if (item < lowest)
            {
                lowest = item - '0';
            }
        }
        Console.WriteLine($"The greatest is {highest} while the lowest is {lowest}");

    }

    private static void Question2()
    {
        /*
        2.Write a program that prints on the console the numbers from 1 to N,
        which are not divisible by 3 and 7 simultaneously. The number N
        should be read from the standard input.
        */
        int a;
        Console.WriteLine("enter a number from 1-N");
        a = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= a; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                Console.WriteLine(i);

            }
        }

    }

    private static void Question1()
    {
        int a;
        Console.WriteLine("enter a number from 1-N");
        a = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= a; i++)
        {
            Console.WriteLine(i);
        }
    }
}