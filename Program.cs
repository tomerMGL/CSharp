﻿using System;

namespace _02_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int mul;
            int i;

            string forI;
            String forMul;

            Console.WriteLine("index = ");
            forI = Console.ReadLine();
            i = Convert.ToInt32(forI);

            Console.WriteLine("mul = ");
            forMul = Console.ReadLine();
            mul = Convert.ToInt32(forMul);
            //--------------------------------------------
            int[] arr1 = new int[i];
            for (int index=0; index < i; index++)
            {
                arr1[index] = index * mul;
            }
            Console.WriteLine($"number for elm = {i} number for mul = {mul}");
            for (int index = 0; index < i; index++)
            {
                Console.WriteLine($"cell = {arr1[index]}");
            }


        }
    }
}
