using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalesTransactionDemo
{
    internal class SalesPerson
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private double SalesAmount { get; set; }

        private double commission { get; set; }
        private readonly double CommissionRate;
        public string firstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First name cannot be null or empty.");
                }
                FirstName = value;
            }
        }
        public string lastName
        {
            get
            {
                return LastName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty.");
                }
                LastName = value;
            }
        }

        public double salesAmount
        {
            get
            {
                return SalesAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Sales amount cannot be negative.");
                }
                SalesAmount = value;
            }
        }
        public double Commission
        {
            get
            {
                return commission;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Commission cannot be negative.");
                }
                commission = value;
            }
        }

        public SalesPerson(string firstName, string lastName, double salesAmount, double commission, double commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SalesAmount = salesAmount;
            Commission = commission;
            CommissionRate = commissionRate;
        }

        // Constructor1
        public SalesPerson(string firstName, string lastName, int salesAmount, double commission, double commissionRate)
        {
            FirstName = firstName;
            LastName = lastName;
            SalesAmount = salesAmount;
            CommissionRate = commissionRate;
            Commission = (SalesAmount * CommissionRate / 100.0);
        }
        // Constructor2
        public SalesPerson(string firstName, string lastName, double salesAmount)
        {
            FirstName = firstName;
            LastName = lastName;
            CommissionRate = 0;
            SalesAmount = salesAmount;
            Commission = 0;
        }
        // Constructor3
        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CommissionRate = 0;
            SalesAmount = 0;
            Commission = 0;
        }

        public static SalesPerson operator +(SalesPerson t1, SalesPerson t2)
        {
            if (t1 == null || t2 == null)
            {
                throw new ArgumentNullException("SalesPerson cannot be null.");
            }
            string combineName1 = $"{t1.FirstName} {t1.LastName} &";
            string combineName2 = $"{t2.FirstName} {t2.LastName}";
            double combineSales = t1.SalesAmount + t2.SalesAmount;
            double combineCommission = t1.Commission + t2.Commission;

            return new SalesPerson(combineName1, combineName2, combineSales, combineCommission, (t1.CommissionRate + t2.CommissionRate) / 2);
        }

        public override string ToString()
        {
            return $"SalesPerson: {FirstName} {LastName}, Sales Amount: {SalesAmount:C}, Commission: {Commission:C}, Commission Rate: {CommissionRate}%";
        }

    }
}
