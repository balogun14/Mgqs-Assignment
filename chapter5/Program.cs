/*
Solution To chapter 5
*/

using System.Collections;

public class Chapter5
{
    public static void Main()
    {
        try
        {
            /*
              1.Write an if-statement that takes two integer variables and exchanges
              their values if the first one is greater than the second one.
              */
            Console.Write("enter first Number: ");
            int a = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("enter second Number: ");
            int b = Convert.ToInt32(Console.ReadLine()!);
            if (a > b)
            {
                (b, a) = (a, b);
            }
            /*
            2.Write a program that shows the sign (+ or -) of the product of three real
                numbers, without calculating it. Use a sequence of if operators.
            */
            /*
            3.Write a program that finds the biggest of three integers, using nested
            if statements.
            */
            Console.Write("enter first Number: ");
            a = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("enter second Number: ");
            b = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("enter third Number: ");
            int c = Convert.ToInt32(Console.ReadLine()!);
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write(a);
                }
            }
            else if (b > a)
            {
                if (b > c)
                {
                    Console.Write(b);
                }
            }
            else if (c > b)
            {
                if (c > a)
                {
                    Console.Write(c);
                }
            }
            //4.Sort 3 real numbers in descending order. Use nested if statements.
            DescendingOrder();
            /*
             5.Write a program that asks for a digit (0-9), and depending on the input,
                shows the digit as a word (in English). Use a switch statement.
            */
            DigitToWord();
            /*
            6.Write a program that gets the coefficients a, b and c of a quadratic
            equation: ax2 + bx + c, calculates and prints its real roots (if they exist).
            Quadratic equations may have 0, 1 or 2 real roots.
            */
            QuadracticEquation();
            /*
            7.Write a program that finds the greatest of given 5 numbers.
            */
            GreatestOfFive();
            /*
            8.Write a program that, depending on the user’s choice, inputs int, double
            or string variable. If the variable is int or double, the program
            increases it by 1. If the variable is a string, the program appends "*" at
            the end. Print the result at the console. Use switch statement.
            */
            Question8();
            /*
            9.We are given 5 integer numbers. Write a program that finds those
            subsets whose sum is 0. Examples:
            - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1
            is 0.
            - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets
            with sum 0.
            */
            Question9();
            /*
            10. Write a program that applies bonus points to given scores in the range
            [1…9] by the following rules:
            - If the score is between 1 and 3, the program multiplies it by 10.
            - If the score is between 4 and 6, the program multiplies it by 100.
            - If the score is between 7 and 9, the program multiplies it by 1000.
            - If the score is 0 or more than 9, the program prints an error
            message.
            */
            Question10();
            /*       
            11. * Write a program that converts a number in the range [0…999] to
            words, corresponding to the English pronunciation. Examples:
            - 0 --> "Zero"
            - 12 --> "Twelve"
            - 98 --> "Ninety eight"
            - 273 --> "Two hundred seventy three"
            - 400 --> "Four hundred"
            - 501 --> "Five hundred and one"
            - 711 --> "Seven hundred and eleven"
            */
            string numberToWord = Question11(500);
            System.Console.WriteLine(numberToWord);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occured: " + ex.Message);
        }
    }

    private static string Question11(int number)
    {
        string[] units = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] tens = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] teens = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        var numberString = Convert.ToString(number);
        if (number < 10)
        {
            return units[number];

        }
        else if (number < 20)
        {
            return teens[number - 10];
        }
        else if (number < 100)
        {

            return tens[number / 10] + " " + units[number % 10];

        }
        else
        {
            if (numberString[1] == '0' && numberString[2] == '0')
            {
                return units[number / 100] + " hundred";

            }

            return units[number / 100] + " hundred and " + Question11(number % 100);

        }
    }

    public static void Question9()
    {
        /*
        9.We are given 5 integer numbers. Write a program that finds those
        subsets whose sum is 0. Examples:
        - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1
        is 0.
        - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets
        with sum 0.
        */
        Console.Write("You\'re to enter 5 integers: ");
        int number = int.Parse(Console.ReadLine()!);
        var numberArray = new int[5];
        int i = 0;
        while (i > 5)
        {
            i++;
            Console.Write("Enter Your Number: ");
            int num = int.Parse(Console.ReadLine()!);
            numberArray.Append(num);
        }
        Random random = new();
        int first = random.Next(0, 4);
        int second = random.Next(0, 4);
        int third = random.Next(0, 4);
        if (numberArray[first] + numberArray[second] + numberArray[third] == 0)
        {
            Console.Write("The subsets of the array is zero");
        }
        else
        {
            Console.Write("The subsets of the array is not zero");
        }
    }

    public static void Question10()
    {
        Console.WriteLine("What is your score within the range 1-9");
        int a = Convert.ToInt32(Console.ReadLine()!);
        switch (a)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine($"You have been given a new point of {a * 10}");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine($"You have been given a new point of {a * 100}");
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine($"You have been given a new point of {a * 1000}");
                break;

            default:
                Console.Write("You don not have any points");
                break;
        }
    }

    private static void Question8()
    {
        /*
        8.Write a program that, depending on the user’s choice, inputs int, double
        or string variable. If the variable is int or double, the program
        increases it by 1. If the variable is a string, the program appends "*" at
        the end. Print the result at the console. Use switch statement.
        */
        Console.Write(" enter a string or int or double");
        string number = Console.ReadLine()!;
        if (!double.TryParse(number, out double convertedNumber))
        {
            Console.WriteLine(number + "*");
            return;
        }
        Console.WriteLine($"{convertedNumber++}");

    }

    private static void GreatestOfFive()
    {
        double a, b, c, d, e, temp;
        Console.WriteLine("This calculates the gretest of the five numbers");
        Console.Write("enter the first for a: ");
        a = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter the second for b: ");
        b = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter the third for c: ");
        c = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter the fouth for d: ");
        d = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter the fifth for e: ");
        e = Convert.ToDouble(Console.ReadLine()!);
        temp = a;
        double[] array = new double[5] { a, b, c, d, e };
        foreach (var item in array)
        {
            if (item > temp)
            {
                temp = item;
            }
        }
        Console.WriteLine($"The greatest is {temp}");
    }

    private static void QuadracticEquation()
    {
        /*
             using general formular x = -b +- sqrt(b^2 - 4ac)/2a
        */
        double a, b, c, x1, x2, temp1, temp2;
        Console.WriteLine("This calculates the root of a quadractic equation");
        Console.Write("enter the coefficient for a: ");
        a = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter the coefficient for b: ");
        b = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter the coefficient for c: ");
        c = Convert.ToDouble(Console.ReadLine()!);
        temp1 = (-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
        x1 = temp1 / (2 * a);
        temp2 = (-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c));
        x2 = temp2 / (2 * a);
        Console.Write($"The roots are {x1}, {x2}");

    }

    public static void DescendingOrder()
    {
        double a, b, c;
        Console.Write("enter first Number: ");
        a = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter second Number: ");
        b = Convert.ToDouble(Console.ReadLine()!);
        Console.Write("enter third Number: ");
        c = Convert.ToDouble(Console.ReadLine()!);
        if (a > b)
        {
            if (b > c)
            {
                Console.Write(a + b + c);
            }
        }
        else if (b > a)
        {
            if (a > c)
            {
                Console.Write(b + a + c);
            }
        }
        else if (c > b)
        {
            if (b > a)
            {
                Console.Write(c + b + a);
            }
        }
        else if (c > b)
        {
            if (a > c)
            {
                Console.Write(c + b + a);
            }
        }
        else if (b > a)
        {
            if (c > a)
            {
                Console.Write(b + c + a);
            }
        }
    }
    public static void DigitToWord()
    {
        Console.Write("enter a number from 0-9: ");
        uint a = Convert.ToUInt32(Console.ReadLine()!);
        switch (a)
        {
            case 0:
                Console.WriteLine("You entered Zero");
                break;
            case 1:
                Console.WriteLine("You entered One");
                break;
            case 2:
                Console.WriteLine("You entered Two");
                break;
            case 3:
                Console.WriteLine("You entered Three");
                break;
            case 4:
                Console.WriteLine("You entered Four");
                break;
            case 5:
                Console.WriteLine("You entered Five");
                break;
            case 6:
                Console.WriteLine("You entered Six");
                break;
            case 7:
                Console.WriteLine("You entered seven");
                break;
            case 8:
                Console.WriteLine("You entered Eight");
                break;
            case 9:
                Console.WriteLine("You entered nine");
                break;
            default:
                Console.WriteLine("You did not follow the instructions: ");
                break;
        }
    }
}