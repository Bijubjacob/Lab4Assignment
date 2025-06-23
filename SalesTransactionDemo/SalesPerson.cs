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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private int SalesAmount { get; set; }

        private int commission { get; set; }

        private readonly int commissionRate = 5; // 5% commission rate

        public int salesAmount
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
        public int Commission
        {
            get
            {
                // Calculate commission based on sales amount and commission rate
                commission = (int)(SalesAmount * commissionRate / 100.0);
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

        public SalesPerson(string firstName, string lastName, int salesAmount, int commission)
        {

            FirstName = firstName;
            LastName = lastName;
            SalesAmount = salesAmount;
            Commission = commission;
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName}, Sales Amount: {SalesAmount}";
        }


    }
}
