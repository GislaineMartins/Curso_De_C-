﻿using System;
using System.Collections.Generic;

namespace Aula05 {
    class Program {
        static void Main(string[] args) {

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4 ,5, 6, 7, 8, 10};
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //diference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);


        }

        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();

        }
    }
}
