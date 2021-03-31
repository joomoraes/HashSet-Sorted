using System;
using System.Collections.Generic;

namespace HashSetESorted
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>()
            { 0,2,4,5,6,8,10 };
            SortedSet<int> b = new SortedSet<int>()
            { 5,6,7,8,9,10,11 };

            //UNION
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintColletion(c);


            // INTERSECTION
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintColletion(d);

            //DIFERENCE
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintColletion(e);
        }

        static void PrintColletion<T>(IEnumerable<T> collection)
        {
            foreach(T obj in collection)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
