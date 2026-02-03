using System.Runtime.CompilerServices;

namespace StaticArraysDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a; // value type - statck - 4 bytes
            a = 10;
            int[] b = new int[a]; // reference type - stack - 4 bytes

            b[0] = 10;
            b[1] = 20;

            // read
            int x = b[0];
            //Console.WriteLine(x);

            // read all values
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }
            int sum = 0;
            int index = 0;
            while (index < b.Length)
            {
                Console.WriteLine(b[index]);
                index++;
                sum += b[index];
            }

            foreach (int item in b)
            {
                Console.WriteLine(item);
            }


            int[] numbers1 = new int[5] { 1, 2, 3, 4, 5 };

            int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };

            int[] numbers3 = { 1, 2, 3, 4, 5 };

            //using (BigData bigData = new BigData())
            //{
            //    bigData.M1();
            //}
            //

            int total = numbers1.Sum();
            int max = numbers1.Max();
            int min = numbers1.Min();
            double average = numbers1.Average();
            int first = numbers1.First();
            int firstThree = numbers1.Take(3).Sum();

            //numbers1.Sort();

            Array.Sort(numbers1); //Assendig Order
            Array.Reverse(numbers1); //Descending Order



            Console.WriteLine($"Total: {total}, Max: {max}, Min: {min}, Average: {average}, First: {first}, FirstThreeSum: {firstThree}");

            // Multi-Dimensional Arrays

            int[,] twoD = new int[3, 5];
            twoD[1, 2] = 20;


            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];
            jaggedArray[2] = new int[10];
        }
    }



    class BigData : IDisposable
    {
        public void Dispose()
        {
            this.Dispose();
            GC.SuppressFinalize(this);
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void M1()
        {

        }
        ~BigData()
        {
            // cleanup code
        }
    }
}
