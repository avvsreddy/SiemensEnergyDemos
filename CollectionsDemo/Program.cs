using System.Collections;

namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // want to store n number of integers

            // use dynamic collections

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            string[] names = { "aaaa", "bbbb" };

            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add("abcd");

            int a = (int)list[0];
            string b = (string)list[1];
            List<int> numbers2 = new List<int>();

            // add data
            numbers2.Add(10);
            numbers2.Add(20);
            numbers2.Add(30);

            // read - use index
            int a2 = numbers2[0];

            Stack<int> stack = new Stack<int>();
            // add
            stack.Push(10);
            stack.Push(20);
            // read
            int x = stack.Pop(); // 20
            x = stack.Peek();

            Queue<int> queue = new Queue<int>();
            //add
            queue.Enqueue(10);
            queue.Enqueue(20);

            // read
            x = queue.Dequeue();
            x = queue.Peek();

            // Key - Value - Dictionary
            Dictionary<int, string> results = new Dictionary<int, string>();
            // add
            results.Add(111, "Pass");
            results.Add(222, "Fail");
            //results.Add(222, "Fail");
            // read
            string result = results[111];









        }
    }
}
