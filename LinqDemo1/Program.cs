using System.Xml.Linq;

namespace LinqDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // LINQ ~ Language Integrated Query 
            //    // SQL ~ For Database 
            //    // LINQ ~ For Any form of data - db, xml, in memory data, fb, ln, ???
            //    // LINQ - Unified Query Language for any data source

            //    // LINQ to Objects

            //    List<int> numbers = new List<int>() { 16, 12, 33, 14, 55, 66, 78, 83, 92 };

            //    // table: numbers
            //    // col : number
            //    // get all even numbers into an array and display
            //    // sql select: select number from numbers where number mod 2 = 0

            //    List<int> evens = new List<int>();
            //    foreach (int n in numbers)
            //    {
            //        if (n % 2 == 0)
            //            evens.Add(n);
            //    }

            //    foreach (int n in evens)
            //    {
            //        Console.WriteLine(n);
            //    }

            //    // sql select: select number from numbers where number mod 2 = 0 order by number desc

            //    Console.WriteLine("Using LINQ");

            //    var evenNumbers = from number in numbers
            //                      where number % 2 == 0
            //                      orderby number descending
            //                      select number;

            //    foreach (int n in evenNumbers)
            //    {
            //        Console.WriteLine(n);
            //    }


            //    List<string> words = new List<string> { "one", "two", "three", "four", "five", "six" };

            //    // extract all short words then display (<= 3)

            //    var shortWords = from word in words
            //                     where word.Length <= 3
            //                     select word;

            //    foreach (var item in shortWords)
            //    {
            //        Console.WriteLine(item);
            //    }

            // LINQ to XML

            XDocument xDoc = XDocument.Load("E:\\Demos\\SiemensEnergy\\SiemensEnergyDemos\\LinqDemo1\\XMLFile1.xml");


            var shortWords = from word in xDoc.Descendants("word")
                             where word.Value.Length <= 3
                             select word.Value;


            foreach (var item in shortWords)
            {
                Console.WriteLine(item);
            }
        }

    }
}
