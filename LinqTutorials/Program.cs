using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task11();
            foreach (object obj in t) 
            {
                Console.WriteLine(obj.ToString());
            }
            int[] array = {1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1};
            var tmp = LinqTasks.Task13(array);
            Console.WriteLine(tmp.ToString());
        }
    }
}
