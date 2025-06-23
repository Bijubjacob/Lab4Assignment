using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesTransactionDemo
{
    internal class SalesCompany
    {
        public string CompanyName { get; set; }
        public List<SalesPerson> SalesPersons { get; private set; }

        public SalesCompany(string companyName)
        {
            CompanyName = companyName;
            SalesPersons = new List<SalesPerson>();
        }

        public SalesPerson AddPerson(string firstName, string lastName, double salesAmount, double commission, double commissionRate)
        {
            SalesPerson salesPerson = new SalesPerson(firstName, lastName, salesAmount, commission, commissionRate);
            SalesPersons.Add(salesPerson);
            return salesPerson;
        }
        

        public double CalculateTotalSales()
        {
            return SalesPersons.Sum(sp => sp.salesAmount);
        }

        public double CalculateTotalCommission()
        {
            return SalesPersons.Sum(sp => sp.Commission);
        }
    }
}
