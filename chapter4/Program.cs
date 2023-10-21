/*
chapter 4 solution
*/

public class Chapter4
{
    public static void Main()
    {

        try
        {
            /*
            1.Write a program that reads from the console three numbers of type int
            and prints their sum.
        */
            SumOfThreeNumber();
            /*
            2.Write a program that reads from the console the radius "r" of a circle
            and prints its perimeter and area.
            */
            PerimeterAndAreaOfACircle();
            /*
            3.A given company has name, address, phone number, fax number, web
            site and manager. The manager has name, surname and phone number.
            Write a program that reads information about the company and its
            manager and then prints it on the console.
            */
            CompanyAndManager();
            /*
            4.Write a program that prints three numbers in three virtual columns
                on the console. Each column should have a width of 10 characters and
                the numbers should be left aligned. The first number should be an
                integer in hexadecimal; the second should be fractional positive; and
                the third – a negative fraction. The last two numbers have to be
                rounded to the second decimal place.
            */
            int hexNum = 2015;
            double fractNum = 1.23856;
            double fractthirdNum = -1.2356;
            Console.WriteLine("|{0,-10:X}|", hexNum);
            Console.WriteLine("|{0,-10:f2}|", fractNum);
            Console.WriteLine("|{0,-10:f2}|", fractthirdNum);

            /*
            5.Write a program that reads from the console two integer numbers (int)
            and prints how many numbers between them exist, such that the
            remainder of their division by 5 is 0. Example: in the range (14, 25)
            there are 3 such numbers: 15, 20 and 25.
            */
            Question5();
            /*
            6.Write a program that reads two numbers from the console and prints the
            greater of them. Solve the problem without using conditional
            statements.
            */
            GreaterNumber();
            /*
             7.Write a program that reads five integer numbers and prints their
            sum. If an invalid number is entered the program should prompt the user
            to enter another number.
            */
            SumOfFiveNumbers();
            /*
            8.Write a program that reads five numbers from the console and prints the
            greatest of them.
            */
            GreatestOfFive();
            /*
             9.Write a program that reads an integer number n from the console. After
                        that reads n numbers from the console and prints their sum.
            */
            NthNumberSum();
            /*
            10. Write a program that reads an integer number n from the console and
            prints all numbers in the range [1…n], each on a separate line.
            */
            NthNumber();
            /*
            11. Write a program that prints on the console the first 100 numbers in the
            Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …
            */
            FibSequence(100);
            /*            
            12. Write a program that calculates the sum (with precision of 0.001) of
            the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
            */
        }
        catch (System.Exception ex)
        {

            Console.WriteLine("An error occured " + ex.Message);
        }

    }

    private static void FibSequence(int n)
    {
        ulong a = 0;
        ulong b = 1;
        Console.Write($"{a}, {b}, ");
        for (int i = 2; i < 100; i++)
        {
            ulong newB = a + b;
            a = b;
            b = newB;
            Console.Write($"{b}, ");
        }
    }

    private static void GreaterNumber()
    {
        Console.Write("Enter the value of the first: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the value of the second: ");
        int b = int.Parse(Console.ReadLine()!);
        string result = (a > b) ? $"{a}" : $"{b}";
        Console.WriteLine(result);
    }

    public static void SumOfThreeNumber()
    {
        Console.WriteLine("You are to enter three numers: ");
        Console.Write("Enter the value of the first: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the value of the second: ");
        int b = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the value of the third: ");
        int c = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"The sum of {a} + {b} + {c} = {a + b + c}");
    }

    public static void PerimeterAndAreaOfACircle()
    {
        Console.Write("Enter your radius: ");
        double r = double.Parse(Console.ReadLine()!);
        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);
        Console.WriteLine($"The perimeter of a circle of radius {r} is {perimeter} and it\'s area is {area}");
    }
    public static void CompanyAndManager()
    {
        Company[] _company = new Company[1];
        Console.Write("What is the company name: ");
        _company[0].name = Console.ReadLine()!;
        Console.Write("What is the company address: ");
        _company[0].address = Console.ReadLine()!;

        Console.Write("What is the company phone Number: ");
        _company[0].phoneNumber = Convert.ToInt64(Console.ReadLine()!);

        Console.Write("What is the company faxNumber: ");
        _company[0].faxNumber = Convert.ToInt64(Console.ReadLine()!);

        Console.Write("What is the company Website: ");
        _company[0].webSite = Console.ReadLine()!;

        Manager[] manager = new Manager[1];
        Console.Write("What is the Manager\'s name: ");
        manager[0].name = Console.ReadLine()!;

        Console.Write("What is the Manger\'s  surname: ");
        manager[0].surname = Console.ReadLine()!;

        Console.Write("What is the Managers\'s phoneNumber: ");
        manager[0].phoneNumber = Convert.ToInt64(Console.ReadLine()!);

        Console.WriteLine($"The Company\'s name is {_company[0].name}\nAddress: {_company[0].address}\nPhone Number: {_company[0].phoneNumber}\nFax Number: {_company[0].faxNumber}");
        Console.WriteLine($"The Company\'s Manager is {manager[0].name}\nSurName: {manager[0].surname}\nPhone Number: {manager[0].phoneNumber}");

    }

    public static void Question5()
    {
        Console.Write("Enter the value of the first: ");
        int a = int.Parse(Console.ReadLine()!);
        Console.Write("Enter the value of the second: ");
        int b = int.Parse(Console.ReadLine()!);
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ", ");
            }
        }

    }
    public static long ConvertToLong(string Message)
    {
        long convertedNumber = 0;
        bool condition = true;
        while (condition)
        {
            Console.Write($"Enter the value of the {Message}: ");
            string number = Console.ReadLine()!;
            if (!long.TryParse(number, out convertedNumber))
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("expected a numeric value ");
                Console.ResetColor();
            }
            else
            {
                return convertedNumber;
            }
        }
        return convertedNumber;
    }
    public static void SumOfFiveNumbers()
    {
        long a, b, c, d, e;

        Console.WriteLine("You are to enter five numers: ");
        a = ConvertToLong("First");
        b = ConvertToLong("second");
        c = ConvertToLong("Third");
        d = ConvertToLong("fouth");
        e = ConvertToLong("fifth");
        Console.WriteLine($"The sum of {a} + {b} + {c} + {d} + {e} = {a + b + c + d + e}");

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

    public static void NthNumberSum()
    {
        Console.Write("Enter your nth value: ");
        int n = Convert.ToInt32(Console.ReadLine()!);
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        Console.WriteLine($"This is the sum {sum}");
    }
    public static void NthNumber()
    {
        Console.Write("Enter your nth value: ");
        int n = Convert.ToInt32(Console.ReadLine()!);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

struct Company
{

    public string name;
    public string address;
    public long phoneNumber;
    public long faxNumber;
    public string webSite;

}
struct Manager
{
    public string name;
    public string surname;
    public long phoneNumber;
}