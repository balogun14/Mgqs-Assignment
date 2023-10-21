/*
Solution to chapter 2 exercises on Fundamentals of computer programming with c#
*/


class Chapter2
{
    static void Main()
    {
        /*
        Question 1 
        Question:Declare several variables by selecting for each one of them the most
        appropriate of the types sbyte, byte, short, ushort, int, uint, long
        and ulong in order to assign them the following values: 52,130; -115;
        4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
        1990; 123456789123456789.
        */
        uint variable1 = 52_130;
        int variable2 = -115;
        uint variable3 = 482_259_32;
        uint variable4 = 97;
        int variable5 = -10_000;
        uint variable6 = 20_000;
        uint variable7 = 224;
        uint varaible8 = 970_700_000;
        uint variable9 = 112;
        int variable10 = -44;
        uint varaible11 = 1_000_000;
        uint variable12 = 1990;
        ulong varaible13 = 123_456_789_123_456_789;

        /*
        Question2:
        Which of the following values can be assigned to variables of type float,
        double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857;
        3456.091124875956542151256683467?
        */
        float valueFloat1 = 5f;
        double valueDouble1 = -5.01d;
        double valueDouble4 = 34.567839023d;
        double valueDouble2 = 12.345d;
        double valueDouble3 = 8923.1234857d;
        decimal valueDecimal3 = 3456.091124875956542151256683467M;

        /*
        Question3:
        Write a program, which compares correctly two real numbers with
        accuracy at least 0.000001.
        */
        bool equals = Math.Abs(valueDouble3 - valueDouble4) >= 0.000001;
        // System.Console.WriteLine(equals);

        /*
        Initialize a variable of type int with a value of 256
        hexadecimal format (256 is 100 in a numeral system with base 16).
        */
        int varable = 256;
        System.Console.WriteLine(varable.ToString("x"));

        /*
        Declare a variable of type char and assign it as a value the character,
        which has Unicode code, 72 (use the Windows calculator in order to find
        hexadecimal representation of 72).
        */
        char Charvariable = '\u0072';
        // System.Console.WriteLine(Charvariable);

        //6.Declare a variable isMale of type bool and assign a value to it depending on your gender.
        bool isMale = true;

        /*
        7.Declare two variables of type string with values "Hello" and "World".
            Declare a variable of type object. Assign the value obtained of
            concatenation of the two string variables (add space if necessary) to this
            variable. Print the variable of type object.
        */
        string hello = "Hello";
        string world = "World";
        object finalWord;
        finalWord = hello + ' ' + world;
        // System.Console.WriteLine(finalWord);
        /*
         8.Declare two variables of type string and give them values "Hello" and
            "World". Assign the value obtained by the concatenation of the two
            variables of type string (do not miss the space in the middle) to a
            variable of type object. Declare a third variable of type string and
            initialize it with the value of the variable of type object (you should use
            type casting).
        */
        string finalString;
        finalString = (string)finalWord;
        /*
        9.Declare two variables of type string and assign them a value “The
            "use" of quotations causes difficulties.” (without the outer quotes).
            In one of the variables use quoted string and in the other do not use it.
        */
        string wordone = "The\"use\" of quotations causes difficulties.";
        string word2 = """The"use" of quotations causes difficulties""";
        /*
        10. Write a program to print a figure in the shape of a heart by the sign "o".
        */
        string[] heart = new string[] {
"             oooooo  ooooo        ",
"           ooooooooo ooooooo      ",
"         ooooooooooooooooooooo    ",
"         ooooooooooooooooooooo    ",
"           ooooooooooooooooo    ",
"             oooooooooooo       ",
"               oooooooo          ",
"                 oooo            ",
"                  oo             ",
};
        // foreach (var item in heart)
        // {
        //     Console.WriteLine(item);
        // }
        /*
        11. Write a program that prints on the console isosceles triangle which
            sides consist of the copyright character "©".
        */
        string[] isocelesTriangle = new string[] {
"                 ©              ",
"             ©        ©         ",
"           ©            ©       ",
"         ©                ©     ",
"       ©                    ©   ",
"     ©                        © ",
"    ©©©©©©©©©©©©©©©©©©©©©©©©©©©© "
};
        // foreach (var item in isocelesTriangle)
        // {
        //     Console.WriteLine(item);
        // }

        /*
        12. A company dealing with marketing wants to keep a data record of its
            employees. Each record should have the following characteristic – first
            name, last name, age, gender (‘m’ or ‘f’) and unique employee number
            (27560000 to 27569999). Declare appropriate variables needed to
            maintain the information for an employee by using the appropriate data
            types and attribute names.
        */
        Random random = new();
        int id = random.Next(27560000, 27569999);
        int MAX_CUSTOMER = 9999;
        MarketingCompany[] marketingCompany = new MarketingCompany[MAX_CUSTOMER];
        marketingCompany[0].firstName = "Awwal";
        marketingCompany[0].lastName = "Baloun";
        marketingCompany[0].age = 10;
        marketingCompany[0].gender = Gender.Male;
        marketingCompany[0].uniqueEmployeeNumber = id;

        /*
        13. Declare two variables of type int. Assign to them values 5 and 10
        respectively. Exchange (swap) their values and print them.
        */
        int first = 5;
        int second = 10;
        (second, first) = (first, second);
        Console.WriteLine($"{first},{second}");

    }

    enum Gender
    {
        Male = 'M',
        Female = 'F'
    }
    struct MarketingCompany
    {
        public string firstName;
        public string lastName;
        public uint age;
        public Gender gender;
        public int uniqueEmployeeNumber;
    }

}

