using System;

namespace Module3.Exercise05
{
    class Program
    {
        static string GradeByIf(int score)
        {
            if (score >= 90) return "A";
            if (score >= 80) return "B";
            if (score >= 70) return "C";
            if (score >= 60) return "D";
            return "F";
        }

        static string GradeBySwitch(int score) => score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        static void Main()
        {
            Console.Write("Enter score (0-100): ");
            if (!int.TryParse(Console.ReadLine(), out var score)) return;
            Console.WriteLine($"Grade (if): {GradeByIf(score)}");
            Console.WriteLine($"Grade (switch): {GradeBySwitch(score)}");
        }
    }
}
