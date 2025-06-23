using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClassifiedAd
{
    public class ClassifiedAd
    {
        public string category { get; set; }
        private double numberOfWords { get; set; }
        private double price { get; set; }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Category cannot be null or empty.");
                }
                category = value;
            }
        }
        public double NumberOfWords
        {
            get
            {
                return numberOfWords;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of words cannot be negative.");
                }
                numberOfWords = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                price = value;
            }
        }
        public ClassifiedAd(string category, double numberOfWords, double price)
        {
            Category = category;
            NumberOfWords = numberOfWords;
            Price = price;
        }

        public double CalculatedPrice(double numberOfWords, int noOfWords)
        {
            if (noOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("Number of words cannot be negative.");
            }

            // Assuming a fixed price per word for simplicity
            const double pricePerWord = 0.09; // Example price per word
            double totalWordCost = noOfWords * pricePerWord;
            return totalWordCost;
        }
    }
}