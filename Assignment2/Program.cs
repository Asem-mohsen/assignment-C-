using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Divisible by 3 and 4
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 3 == 0 && number % 4 == 0)
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            #endregion


            #region Divisible by 3 and 4
                Console.Write("Enter an integer: ");
                int number2 = int.Parse(Console.ReadLine());

                if (number2 < 0)
                    Console.WriteLine("negative");
                else
                    Console.WriteLine("positive");
            #endregion

            #region Positive or Negative
                Console.Write("Enter an integer: ");
                int number3 = int.Parse(Console.ReadLine());

                if (number3 < 0)
                    Console.WriteLine("negative");
                else
                    Console.WriteLine("positive");
            #endregion

            #region Max and Min of 3 Integers
                Console.Write("Enter three numbers: ");
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);

                int max = Math.Max(a, Math.Max(b, c));
                int min = Math.Min(a, Math.Min(b, c));

                Console.WriteLine($"Max = {max}");
                Console.WriteLine($"Min = {min}");
            #endregion

            #region Even or Odd
                Console.Write("Enter an integer: ");
                int number4 = int.Parse(Console.ReadLine());

                if (number4 % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            #endregion

            #region  Vowel or Consonant
                Console.Write("Enter a character: ");
                char ch = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if ("aeiou".IndexOf(ch) != -1)
                    Console.WriteLine("Vowel");
                else
                    Console.WriteLine("Consonant");
            #endregion

            #region Multiplication Table
                Console.Write("Enter a number: ");      
                int number5 = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{number5} x {i} = {number5 * i}");
                }
            #endregion

            #region  Power Calculation
                Console.Write("Enter the base: ");
                int basenum = int.Parse(Console.ReadLine());

                Console.Write("Enter the exponent: ");
                int exp = int.Parse(Console.ReadLine());

                int result = (int)Math.Pow(basenum, exp);
                Console.WriteLine($"Result: {result}");
            #endregion

            #region Marks Total, Average, Percentage
                int[] marks = new int[5];
                Console.WriteLine("Enter marks of five subjects:");

                for (int i = 0; i < 5; i++)
                {
                    marks[i] = int.Parse(Console.ReadLine());
                }

                int total = 0;
                foreach (int mark in marks) total += mark;

                float average = total / 5f;
                float percentage = (total / 500f) * 100;

                Console.WriteLine($"Total Marks = {total}");
                Console.WriteLine($"Average Marks = {average}");
                Console.WriteLine($"Percentage = {percentage}%");
            #endregion

            #region Days in Month
                Console.Write("Enter the month number: ");
                int month = int.Parse(Console.ReadLine());

                int days = month switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28,
                    _ => throw new Exception("Invalid month")
                };

                Console.WriteLine($"Days in Month: {days}");
            #endregion

            #region Points on a Straight Line
                Console.WriteLine("Enter points: ");
                int x1 = int.Parse(Console.ReadLine());
                int y1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter points: ");
                int x2 = int.Parse(Console.ReadLine());
                int y2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter points: ");
                int x3 = int.Parse(Console.ReadLine());
                int y3 = int.Parse(Console.ReadLine());

                int determinant = (x2 - x1) * (y3 - y1) - (y2 - y1) * (x3 - x1);
                if (determinant == 0)
                    Console.WriteLine("Points are on a straight line.");
                else
                    Console.WriteLine("Points are not on a straight line.");
            #endregion

            #region Worker Efficiency
                Console.Write("Enter time taken (in hours): ");
                float time = float.Parse(Console.ReadLine());

                if (time >= 2 && time <= 3)
                    Console.WriteLine("Highly Efficient");
                else if (time > 3 && time <= 4)
                    Console.WriteLine("Increase Speed");
                else if (time > 4 && time <= 5)
                    Console.WriteLine("Training Required");
                else
                    Console.WriteLine("Leave the company");
            #endregion

            #region 23
            //!(30<20) which is !(false) then it means true and true is 1 so d =1 
            #endregion

            #region 24
            // Console.WriteLine(13 / 2 + " " + 13 % 2) = 61
            #endregion

            #region 25
            // 7 7
            #endregion
        }
    }
}
