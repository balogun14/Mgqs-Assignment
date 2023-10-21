/*
Solution to chapter 3 exercises on Fundamentals of computer programming with c#
*/
class Chapter3
{
    public static void Main()
    {
        try
        {
            // 1.Write an expression that checks whether an integer is odd or even.
            Console.Write("What is your number: ");
            int number;

            number = int.Parse(Console.ReadLine()!);
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd");
            }

            /*
            2.Write a Boolean expression that checks whether a given integer is
            divisible by both 5 and 7, without a remainder.
            */
            bool result;
            Console.Write("What is your number: ");
            number = int.Parse(Console.ReadLine()!);
            
            if (number % 5 == 0 && number % 7 == 0)
            {
                result = true;
                System.Console.WriteLine(result);
            }

            else
            {
                result = false;
                System.Console.WriteLine(result);
            }
            /*
            3.Write an expression that looks for a given integer if its third digit (right
             to left) is 7.
            */
            Console.Write("What is your number: ");
            string digit = Console.ReadLine()!;
            if (digit[2] == '7')
            {
                Console.WriteLine("Number 7 is present at the third position");
            }
            else
            {
                Console.WriteLine("Number 7 is absent at the third position");

            }
            /*

            4.Write an expression that checks whether the third bit in a given integer
            is 1 or 0.
            */
            Console.Write("What is your number: ");
            digit = Console.ReadLine()!;
            if (digit[2] == '0' || digit[2] == '1')
            {
                Console.WriteLine($"Number {digit[2]} is present at the third position");
            }
            else
            {
                Console.WriteLine("Number  0 or 1 is absent at the third position");

            }

            /*
            5.Write an expression that calculates the area of a trapezoid by given
            sides a, b and height h.
            */
            AreaOfTrapezium(10, 15, 20);
            /*
             6.Write a program that prints on the console the perimeter and the area
            of a rectangle by given side and height entered by the user.
            */
            PerimeterAndAreaOfRectangle(10, 20);
            /*
            7.The gravitational field of the Moon is approximately 17% of that on the
            Earth. Write a program that calculates the weight of a man on the
            moon by a given weight on the Earth.
            */
            // weight on moon =weight on earth * moon gravitational field/ earth gravitational field

            double earthGravitationalField = 9.80665d;
            double moonGravitationalField = earthGravitationalField * 0.17;
            Console.Write("What is the weight on earth: ");
            double weightOnEarth = double.Parse(Console.ReadLine()!);
            double weightOnMoon = weightOnEarth * (moonGravitationalField / earthGravitationalField);
            Console.WriteLine($"The weight on the moon is {weightOnMoon}kg");
            /*
            8.Write an expression that checks for a given point {x, y} if it is within
            the circle K({0, 0}, R=5). Explanation: the point {0, 0} is the center of
            the circle and 5 is the radius.
            */
            double x;
            double y;
            Console.Write("Enter your x cordinate: ");
            x = double.Parse(Console.ReadLine()!);
            Console.Write("Enter Your y cordinate ");
            y = double.Parse(Console.ReadLine()!);

            if ((x * x) + (y * y) <= (5 * 5))
            {
                Console.WriteLine("The cordinates you specified is within the center of the circle");
            }
            else
            {
                Console.WriteLine("The cordinates you specified is not  within the center of the circle");

            }
            /*
            9.Write an expression that checks for given point {x, y} if it is within the
            circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}].
            Clarification: for the rectangle the lower left and the upper right corners
            are given.
            solution: To solve this let's calculate the area of the rectangle
            to do that we use the cordinates provided
            lenght = x2 - x1
            width = y2 -y1
            area = length*width
            */
            double lenght = 5 - (-1);
            double width = 5 - 1;
            double area = lenght * width;
            // System.Console.WriteLine(area);
            if ((x * x) + (y * y) <= (5 * 5) && (x * x) + (y * y) > area)
            {
                Console.WriteLine("The cordinates you specified is within the center of the circle amd out of the rectangle");
            }
            else
            {
                Console.WriteLine("The cordinates you specified is not  within the center of the circle and inside the rectangle");

            }
            /*
                  10. Write a program that takes as input a four-digit number in format abcd
                        (e.g. 2011) and performs the following actions:
                        - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
                        - Prints on the console the number in reversed order: dcba (in our
                        example 1102).
                        - Puts the last digit in the first position: dabc (in our example 1201).
                        - Exchanges the second and the third digits: acbd (in our example
                        2101)
            */
            Console.Write("Enter a four digit number in format abcd (e.g 2010): ");
            string digits = Console.ReadLine()!;
            int sum = 0;
            int count = digits.Length;
            if (count > 4)
            {
                Console.WriteLine("You did not follow the instructions!");
            }
            else
            {
                foreach (var item in digits)
                {
                    int character = item - '0';
                    sum += character;
                }
                Console.WriteLine($"The sum is {sum}");
                Console.WriteLine("This is the reverse order");
                for (int i = 3; i >= 0; i--)
                {
                    Console.Write(digits[i]);
                }
                char firstDigit = digits[0];
                System.Console.WriteLine("\n" + firstDigit);
                char lastDigit = digits[3];
                char oldFirst = firstDigit;
                (firstDigit, lastDigit) = (lastDigit, firstDigit);
                Console.Write($"The new string is this when the first and last digit is swapped: {firstDigit}{digits[1]}{digits[2]}{lastDigit}");
                Console.Write($"The new string is this when the last digit is placed in the first position: {digits[3]}{digits[0]}{digits[1]}{digits[2]}");
                Console.Write($"The new string is this when the second digit is swapped with the third digit: {digits[0]}{digits[2]}{digits[1]}{digits[3]}");


                // }
                /*
                11. We are given a number n and a position p. Write a sequence of
                operations that prints the value of the bit on the position p in the
                number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35,
                p=6 -> 0.
                */
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine()!);
                Console.Write("Enter a position: ");
                int p = int.Parse(Console.ReadLine()!);
                int mask = n << p;
                GetBit(n, p);

                /*
                 12. Write a Boolean expression that checks if the bit on position p in the
                            integer v has the value 1. Example v=5, p=1 -> false.
                */
                int v;
                Console.Write("Enter value for v: ");
                v = int.Parse(Console.ReadLine()!);
                bool isBitSet = (v & (mask)) != 0;

                /*
                13. We are given the number n, the value v (v = 0 or 1) and the position p.
                            write a sequence of operations that changes the value of n, so the bit on
                            the position p has the value of v. Example: n=35, p=5, v=0 -> n=3.
                            Another example: n=35, p=2, v=1 -> n=39.
                */
                int maskBit = 1 << p;
                Console.WriteLine((~mask) & n);
                /*

            14. Write a program that checks if a given number n (1 < n < 100) is a
            prime number (i.e. it is divisible without remainder only to itself and 1).
                */
                Console.Write("Enter an integer between [1...100]:");
                int pnumber = int.Parse(Console.ReadLine()!);
                Console.WriteLine(IsPrimeNumber(pnumber));

                /*
                  15. * Write a program that exchanges the values of the bits on positions
                                3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned
                                integer.
                */
                BitExchanger(10);
                /*
                              16. * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q,
                q+1, …, q+k-1} of a given 32-bit unsigned integer.
                */



            }
        }
        catch (FormatException ex)
        {

            Console.WriteLine("Something Went wrong " + ex.Message);
        }
        catch (Exception esx)
        {
            Console.WriteLine("An error occured" + esx.Message);

        }
    }
    public static void AreaOfTrapezium(double a, double b, double height)
    {
        double result = (double)(1 / 2) * (a + b) * height;
        Console.WriteLine($"The area of thr trapezium is {result}");
    }
    public static void PerimeterAndAreaOfRectangle(double lenght, double breadth)
    {
        double perimeter = 2 * (lenght + breadth);
        double area = lenght * breadth;
        Console.WriteLine($"The area is {area} and the perimeter is {perimeter}");
    }
    public static void GetBit(int n, int p)
    {
        int mask = 1 << p;
        int bitValue = (n & mask) >> p;
        Console.Write(bitValue);
    }
    public static bool IsPrimeNumber(int number)
    {
        if (number < 2) return false;
        for (int i = 1; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }
        return true;
    }
    public static uint BitExchanger(uint number)
    {
        uint mask1 = (1u << 3) | (1u << 4) | (1u << 5);
        uint mask2 = (1u << 24) | (1u << 25) | (1u << 26);
        uint bit1 = number & mask1;
        uint bit2 = number & mask2;

        bit1 <<= 21;
        bit2 >>= 21;

        number &= ~(mask1 | mask2);
        number |= bit1 | bit2;
        return number;
    }
}
