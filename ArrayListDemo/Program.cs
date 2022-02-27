using System;
using System.Collections;

namespace ArrayListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine("Initial Capacity: " + al.Capacity);//0
            al.Add(10);
            //As soon as first data is added, initial capacity becomes 4.
            //and it doubles everytime when required.
            Console.WriteLine("Capacity after adding 1st Item: " + al.Capacity);//4
            al.Add(true);
            al.Add('A');
            al.Add("Hello");
            Console.WriteLine("Capacity after adding 4th Item: " + al.Capacity);//4
            al.Add(67.56);
            Console.WriteLine("Capacity after adding 5th Item: " + al.Capacity);//8
            Console.WriteLine("Total number of Item: " + al.Count);//5

            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();
            for (int i = 0; i < al.Count; i++)
                Console.Write(al[i] + " ");
            Console.WriteLine();

            ArrayList coll = new ArrayList(al);
            Console.WriteLine("Initial capacity of new collection: " + coll.Capacity);//5
            coll.Add(false);
            Console.WriteLine("Capacity of new collection after adding new item: " + coll.Capacity);//10

            foreach (object obj in coll)
                Console.Write(obj + " ");
            Console.ReadLine();
        }
    }
}
