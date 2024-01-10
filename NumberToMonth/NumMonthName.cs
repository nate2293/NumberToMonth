namespace NumberToMonth
{
    internal class NumMonthName
    {
        static void Main()
        {
            Console.WriteLine(MonthName(3));    // Output: "March"
            Console.WriteLine();
            Console.WriteLine(MonthName(12));   // Output: "December"
            Console.WriteLine();
            Console.WriteLine(MonthName(6));    // Output: "June"
            Console.WriteLine();
        }

        static string MonthName(int number)
        {
            string[] months = {
            "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"
        };

            if (number >= 1 && number <= 12)
            {
                return months[number - 1];
            }
            else
            {
                return "Invalid month number. Please enter a number between 1 and 12.";
            }
        }
    }
}