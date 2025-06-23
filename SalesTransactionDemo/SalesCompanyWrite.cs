using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SalesTransactionDemo
{
    internal class SalesCompanyWrite
    {
        public static void WriteSalesCompanyToScreen(SalesCompany salesCompany)
        {
            WriteLine($"Company: {salesCompany.CompanyName}");
            WriteLine("Sales Persons:");
            foreach (var salesPerson in salesCompany.SalesPersons)
            {
                WriteLine($"- {salesPerson.firstName} {salesPerson.lastName}, Sales Amount: {salesPerson.salesAmount}, Commission: {salesPerson.Commission}");
            }
            WriteLine($"Total Sales: {salesCompany.CalculateTotalSales()}");
            WriteLine($"Total Commission: {salesCompany.CalculateTotalCommission()}");
            WriteLine();
        }
    }
}