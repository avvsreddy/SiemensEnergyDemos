namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int fno, sno, sum;
                    Console.Write("Enter First Nummber :"); // open db connection
                    fno = int.Parse(Console.ReadLine()); // read
                    Console.Write("Enter Second Number :"); // write
                    sno = int.Parse(Console.ReadLine());

                    sum = fno + sno;

                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                    // close the db connection

                    // code for withdraw

                    int balance = 5000;
                    int amount = 10000;

                    if (balance >= amount)
                    {
                        balance -= amount;
                    }
                    else
                    {
                        throw new InsufficientBalanceExeption();
                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter only numbers");
                }
                //catch (OverflowException ex)
                //{
                //    Console.WriteLine("Please enter small numbers only");
                //}
                catch (Exception ex) // catch all unhandled exceptions
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    Console.WriteLine("Executes always");
                }

            }
        }
    }

    class InsufficientBalanceExeption : ApplicationException
    {

    }
}
