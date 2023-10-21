// Solution to Chapter 8
class Program
{
    public static void Main()
    {
        try
        {
            /*
            Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary
numeral system.
            */
            string one, teo, three, four, five, six;
            one = DecimalToBinary(151);
            teo = DecimalToBinary(35);
            three = DecimalToBinary(43);
            four = DecimalToBinary(251);
            five = DecimalToBinary(1023);
            six = DecimalToBinary(1024);
            Console.WriteLine($"{one}\n{teo}\n{three}\n{four}\n{five}\n{six}");
            Question2();
            Question3();
            Question13();
            Question14();
            u
        }
        catch (System.Exception ex)
        {
            Console.WriteLine("An Error Occured " + ex.Message);
        }
    }

    private static void Question14()
    {
        /*
        Try adding up 50,000,000 times the number 0.000001. Use a loop
and addition (not direct multiplication). Try it with float and double and
after that with decimal. Do you notice the huge difference in the
results and speed of calculation? Explain what happens.
        */
        float floatNumber = 0.0f;
        double doubleNumber = 0.0d;
        decimal decimalNumber = 0.0M;
        for (int i = 0; i < 50000000; i++)
        {
            floatNumber += 0.000001f;
            doubleNumber += 0.000001d;
            decimalNumber += 0.000001M;
        }
        Console.WriteLine(floatNumber);
        Console.WriteLine(decimalNumber);
        Console.WriteLine(doubleNumber);

    }

    private static void Question3()
    {
        /*
        Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and
decimal numeral systems.
        */
        string one, teo, three, four;
        string num1 = "FA";
        string num2 = "2A3E";
        string num3 = "FFFF";
        string num4 = "5A0E9";
        int binNum1 = HexToDecimal(num1);
        int binNum2 = HexToDecimal(num2);
        int binNum3 = HexToDecimal(num3);
        int binNum4 = HexToDecimal(num4);
        one = DecimalToBinary(binNum1);
        teo = DecimalToBinary(binNum2);
        three = DecimalToBinary(binNum3);
        four = DecimalToBinary(binNum4);
        Console.WriteLine($"{binNum1}, {binNum2}, {binNum3}, {binNum4}");
        Console.WriteLine($"{one}, {teo}, {three}, {four}");

    }

    //Question13
    public static string Question13()
    {
        /*
        Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number
N from an S-based numeral system to a D based numeral system.
        */ 
        Console.Write("Conversion from s numeral to d number: ");
        int number = int.Parse(Console.ReadLine()!);
        string decimalNumber = number.ToString("d");
        int deimal = Convert.ToInt32(decimalNumber);
        Console.Write("Conversion what number do you want to convert to \n1.HexaDecimal\n2.Binary\n3Decimal: ");
        int userChoice = int.Parse(Console.ReadLine()!);
        string hexNumber = DecimalToHex(deimal);
        string binaryNumber = DecimalToBinary(deimal);
        switch (userChoice)
        {
            case 1:
                Console.WriteLine($"{number} is {hexNumber} in HexaDecimal");
                break;
            case 2:
                Console.WriteLine($"{number} is {binaryNumber} in Binary");
                break;
            case 3:
                Console.WriteLine($"{number} is {decimalNumber} in Decimal");
                break;
            default:
                Console.WriteLine("You did not specify a number read the instructions again");
                break;
        }


        return "";
    }
    //Question 10
    public static string HornerScheme()
    {
        /*
        Write a program that converts a binary number to decimal using the
Horner scheme.
        */
        return "";
    }
    //Question9
    public static string BinaryToHexadecimal(string number)
    {
        /*
        Write a program that converts a binary number to hexadecimal one.
        */
        int decimalNumber = BinaryToDecimal(number);
        string hexNumber = DecimalToHex(decimalNumber);
        return hexNumber;
    }
    //Question 8
    public static string HexToBinary(string number)
    {
        /*
        Write a program that converts a hexadecimal number to binary one.
        */
        int decimalNumber = Convert.ToInt32(number, 16);
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }
    //Question7
    public static int HexToDecimal(string number)
    {
        /*
        Write a program that converts a hexadecimal number to decimal one.
        */
        int decimalNumber = Convert.ToInt32(number, 16);
        return decimalNumber;
    }
    //Question 6
    public static string DecimalToHex(int number)
    {
        /*
        Write a program that converts a decimal number to hexadecimal one.
        */
        string HexaDecimal = number.ToString("X");
        return HexaDecimal;
    }

    private static void Question2()
    {
        /*
        Convert the number 1111010110011110(2) to hexadecimal and decimal
numeral systems.
        */
        string number = "1111010110011110";
        int decimalNumber = BinaryToDecimal(number);
        Console.WriteLine(decimalNumber);
        string HexaDecimal = DecimalToHex(decimalNumber);
        Console.WriteLine(HexaDecimal);

    }

    //Question 5
    public static int BinaryToDecimal(string binaryNumber)
    {
        /*
        Write a program that converts a binary number to decimal one.
        */
        int number = Convert.ToInt32(binaryNumber, 2);
        return number;
    }
    //Question 4
    public static string DecimalToBinary(int decimalNumber)
    {
        /*
        Write a program that converts a decimal number to binary one.
        */
        string binaryNumber = "";

        while (decimalNumber > 0)
        {
            int remainder = decimalNumber % 2;
            binaryNumber = remainder + binaryNumber;
            decimalNumber /= 2;
        }

        return binaryNumber;
    }
}