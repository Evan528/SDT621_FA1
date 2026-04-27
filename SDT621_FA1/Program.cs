using System;

class SDT621_FA1
{
    static void Main()
    {
        // input
        Console.Write("Enter Student name: ");
        string name = Console.ReadLine() ?? "Student";

        int totalMarks = 0;
        int subjectCount = 0;

        while (true)
        {
            Console.Write($"Enter mark for Subject {subjectCount + 1} (Type 'done' to stop): ");
            string input = Console.ReadLine() ?? "";

            // stop condition
            if (input.ToLower() == "done")
            {
                break;
            }

            // validate number
            if (int.TryParse(input, out int mark))
            {
                totalMarks += mark;
                subjectCount++;
            }
            else
            {
                Console.WriteLine("Invalid input (Must be a number!!!)");
            }
        }

        // process
        int averageMarks = subjectCount > 0 ? totalMarks / subjectCount : 0;
        string result = (averageMarks >= 50) ? "PASS" : "FAIL";

        // output
        Console.WriteLine("\n==== Student Results ====");
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Average Marks: " + averageMarks);
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Result time stamp: " + DateTime.Now.ToString("dd MMM yyy HH:mm:ss"));
    }
}