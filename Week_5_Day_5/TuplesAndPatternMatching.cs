using System;

class TupleAndPatternMatching
{
    // Method to return sales and rating as a tuple
    static (double Sales, int Rating) GetEmployeePerformance(double sales, int rating)
    {
        return (sales, rating);
    }

    static void Main()
    {
        // Input Employee Name
        Console.Write("Enter Employee Name: ");
        string employeeName = Console.ReadLine();

        // Input Monthly Sales Amount
        Console.Write("Enter Monthly Sales Amount: ");
        bool isSalesValid = double.TryParse(Console.ReadLine(), out double salesAmount);
        while (!isSalesValid || salesAmount < 0)
        {
            Console.Write("Invalid input. Enter a valid Sales Amount: ");
            isSalesValid = double.TryParse(Console.ReadLine(), out salesAmount);
        }

        // Input Customer Feedback Rating
        Console.Write("Enter Customer Feedback Rating (1-5): ");
        bool isRatingValid = int.TryParse(Console.ReadLine(), out int rating);
        while (!isRatingValid || rating < 1 || rating > 5)
        {
            Console.Write("Invalid input. Enter Rating between 1 and 5: ");
            isRatingValid = int.TryParse(Console.ReadLine(), out rating);
        }

        // Get tuple from method
        var performance = GetEmployeePerformance(salesAmount, rating);

        // Determine Performance Category using pattern matching
        string performanceCategory = performance switch
        {
            ( >= 100000, >= 4) => "High Performer",
            ( >= 50000, >= 3) => "Average Performer",
            _ => "Needs Improvement"
        };

        // Display results
        Console.WriteLine("\n--- Employee Performance ---");
        Console.WriteLine($"Employee Name: {employeeName}");
        Console.WriteLine($"Sales Amount: {performance.Sales}");
        Console.WriteLine($"Rating: {performance.Rating}");
        Console.WriteLine($"Performance: {performanceCategory}");
    }
}
