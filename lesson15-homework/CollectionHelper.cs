using System;
using System.Collections.Generic;
using System.Text;

namespace lesson15_homework
{
    internal static class CollectionHelper
    {
         public static void PrintReverse<T>(this IList<T> collection)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(collection[i]);
            }
        }

        public static T GetFirstElement<T>(this IList<T> collection)
        {

            return collection[0];
        }

        public static T GetLastElement<T>(this IList<T> collection)
        {
            return collection[collection.Count - 1];
        }

        public static bool ContainsElement<T>(this IList<T> collection, T element)
        {
            foreach (var item in collection)
            {
                if (item.Equals(element))
                {
                    return true;
                }
            }
            return default;
        }



        public static int CountElements<T>(this IList<T> collection)
        {
            int count = 0;
            foreach (var item in collection)
            {
                count++;
            }
            return count;
        }


        public static int FindIndex<T>(this IList<T> collection, T element)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
    }

}
