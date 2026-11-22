using System;
using System.Collections.Generic;
using System.Text;

namespace lesson14_homework
{
    internal static class ArrayHelper
    {

        public static T Where<T>(this T[] arr, Predicate<T> pred)
        {
            T[] newArr = [];
            foreach (var item in arr)
            {
                if (pred(item))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                }
            }
           
            return default;
        }


        public static T FirstOrDefault<T>(this T[] arr, Predicate<T> pred)
        {
            foreach (var item in arr)
            {
                if (pred(item))
                {
                    return item;
                }
            }
            return default;
        }

        public static bool Any<T>(this T[] arr, Predicate<T> pred)
        {
            foreach (var item in arr)
            {
                if (pred(item))
                {
                    return true;
                }
            }
            return default;
        }

        public static bool All<T>(this T[] arr, Predicate<T> pred)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (pred(item))
                {
                    count++;
                }


            }
            if (count == arr.Length)
            {
                return true;
            }
            else
            {
                return false;
                
            }
            return default;
        }


        public static int Count<T>(this T[] arr, Predicate<T> pred)
        {
            int count = 0;
            int count1 = 0;
            foreach (var item in arr)
            {
                if (pred(item))
                {
                    count++;
                }
                else
                {
                    count1++;
                }

            }
            if (pred != null)
            {
                return count;
            }
            else
            {
                return count1;
            }
            return default;
        }
    }
}
