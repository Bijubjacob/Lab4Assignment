namespace SalesTransactionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new sales company
            SalesCompany salesCompany = new SalesCompany("Tech Sales Inc.");
            // Add sales persons to the company
            salesCompany.AddPerson("Alice", "Johnson", 15000, 2250, 0.15);
            salesCompany.AddPerson("Bob", "Smith", 20000, 3000, 0.15);
            salesCompany.AddPerson("Charlie", "Brown", 12000, 1800, 0.15);
            // Write the sales company details to the console
            SalesCompanyWrite.WriteSalesCompanyToScreen(salesCompany);
            // Create a list of sales persons
            List<SalesPerson> salesPersons = salesCompany.SalesPersons;
            // Write the sales persons details to the console
            SalesPersonWrite.WriteSalesPersonToScreen(salesPersons);
            // Calculate and display total sales and commission
            double totalSales = salesCompany.CalculateTotalSales();
            double totalCommission = salesCompany.CalculateTotalCommission();
            Console.WriteLine($"Total Sales: {totalSales}");
            Console.WriteLine($"Total Commission: {totalCommission}");
            //Display combine sales persons and company details
            SalesPerson combined = salesPersons[0] + salesPersons[1];
            Console.WriteLine($"Combined Sales Person: {combined.firstName} {combined.lastName}, Sales Amount: {combined.salesAmount}, Commission: {combined.Commission}");
            
            // Wait for user input before closing the console window
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}