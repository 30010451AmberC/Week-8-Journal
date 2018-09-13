using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_Exercises
{
    class Program //Task 1:
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"The input {num} changed is: {ChangeSign(num)}");
            Console.ReadLine();
        }

        public static int ChangeSign(int num)
        {
            return num *-1;
        }
    }

    class Program2 //Task2:
    {
        public static void Task2()
        {
            
            Console.WriteLine("Please enter how many miles your drove: ");
            double num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num} in kilometers is {Conversion(num)}");
            
        }

        public static double Conversion(double num)
        {
            return num /.62137;
        }
    }

    class Program3 //Task3
    {
        public static void Task3()
        {
            Console.WriteLine("Please enter circle radius: ");
            float Radius = int.Parse(Console.ReadLine());

            Console.WriteLine($"Circumference is: {Circumference(Radius)}");
            Console.WriteLine($"Area is: {Area(Radius)}");
        }

        public static float Circumference(float Radius)
        {
            return 2 * 3.1416F * Radius; // F cuts off decimal there. F refers to float type.
        }

        public static float Area(float Radius)
        {
            return 3.1416F * (Radius * Radius);
        }
    }

    class Program4 //Task4
    {
        public static void Task4()
        {
            string[] Days = {"Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };
            Console.WriteLine("Please enter a number and I will tell you the corrosponding day: ");
            int Num = int.Parse(Console.ReadLine());
            WhatDay(Num, Days);
        }

        public static void WhatDay(int Num, string[] Days)
        {
            Console.WriteLine($"The day is: {Days[Num - 1]}");
        }
    }
}
