//using Siemens.CodeLibrary;

//using Siemens.CodeLibrary;

using Siemens.CodeLibrary;

namespace LanguageEssentials // UI
{
    internal class Program // UI - SRP 
    {
        static void Main(string[] args) // UI Logic SRP
        {
            // accept two numbers from the user and print maximum

            int num1, num2, max;
            Console.WriteLine("Enter first number :");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            num2 = int.Parse(Console.ReadLine());
            //max = (num1 > num2) ? num1 : num2;

            Program program = new Program();

            //max = program.FindMax(num1, num2);
            SimpleMath simpleMath = new SimpleMath();

            max = simpleMath.FindMax(num1, num2);

            //Program.FindMax(num1, num2);

            //Console.WriteLine("Maximum is : " + max);
            //Console.WriteLine("The max of {0} and {1} is {2}", num1, num2, max);

            Console.WriteLine($"The max of {num1} and {num2} is {max}");

        }
    }


}

