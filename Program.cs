using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                list.AddHead(i);
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        
    }
}
