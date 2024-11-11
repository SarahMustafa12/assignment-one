namespace assignmentOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning Service\n    Charges:\n   " +
                "     $25 per small\n        $35 per large\n " +
                "   Sales tax rate is 6% \n   " +
                " Estimates are valid for 30 days\n");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enter the number of small carpet:");
            int numberOfSmallCarpet = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of large carpet:");
            int numberOfLargeCarpet = int.Parse(Console.ReadLine());
            int primaryCost = (numberOfLargeCarpet * 35 + numberOfSmallCarpet * 25);
            double tax = primaryCost * 0.06;
            double totalCost = tax + primaryCost;
            Console.WriteLine($"The total cost = {totalCost:C}");
            Console.WriteLine("this estimate is vaild for 30 days.");


        }
    }
}
