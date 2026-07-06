namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        // Step 1
        /* Name: Maxwell Niswander
          Title: IT-1050 - Lab 1 */

        // Step 2
        Console.WriteLine("Maxwell Niswander");
        Console.WriteLine("IT-1050");

        //Step 3
        int favNum = 38;
        string favProgram = "Javascript";
        double numOfPrograms = 1000000000000d;
        bool programExperience = true;

        Console.WriteLine("My Favorite Number is" + favNum );
        Console.WriteLine("The programming language I know best is" + favProgram );
        Console.WriteLine("The number of programs I have made is (slightly exxagerated)" + numOfPrograms + "programs");
        Console.WriteLine("If you asked me if I have programming experience, I would say that that is" + programExperience);

        //Step 4
        const string schoolName = "John Carroll University";
        Console.WriteLine("My school's name is" + schoolName );

        //Step 5
        double doubleValue = 9.78;
        int intValue = (int)doubleValue;

        int number = 42;
        string numberString = Convert.ToString(number);

        bool flag = true;
        string boolString = Convert.ToString(flag);

        Console.WriteLine("double: " + doubleValue);
        Console.WriteLine("int (cast): " + intValue);
        Console.WriteLine("int to string: " + numberString);
        Console.WriteLine("bool to string: " + boolString);

        //Step 6
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + name + ", you are " + age + " years old.");

        // Step 7
        int num1 = 20;
        int num2 = 6;

        Console.WriteLine("Addition: " + (num1 + num2));
        Console.WriteLine("Subtraction: " + (num1 - num2));
        Console.WriteLine("Multiplication: " + (num1 * num2));
        Console.WriteLine("Division: " + (num1 / num2));
        Console.WriteLine("Modulus: " + (num1 % num2));

        // Step 8
        float floatValue = 1.123456789f;
        double doubleValue1 = 1.123456789d;

        Console.WriteLine("float: " + floatValue);
        Console.WriteLine("double: " + doubleValue1);

        // Step 9
        int incremental = 10;

        incremental++;
        Console.WriteLine("After increment: " + incremental);

        incremental--;
        Console.WriteLine("After decrement: " + incremental);


    }
}
