using System;

namespace Switch_statement_method_by_number_of_week_day_and_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayofweek = 1;

            switch (dayofweek)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesdays");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day of the week");
                    break;
            }
        }
    }
}
