using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesTransactionDemo;
using static System.Console;


namespace SalesTransactionDemo
{
    internal class SalesPersonWrite
    {
        public static void WriteSalesPersonToScreen(List<SalesPerson> salesPersons)
        {
            foreach (SalesPerson salesPerson in salesPersons)
            {
                WriteLine($"Sales Person: {salesPerson.firstName} {salesPerson.lastName}, Sales Amount: {salesPerson.salesAmount}, Commission: {salesPerson.Commission}");
            }
        }
    }
}