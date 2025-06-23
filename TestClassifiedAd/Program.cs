using System;
using TestClassifiedAd;
using static System.Console;

namespace TestClassifiedAd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new classified ad
            ClassifiedAd ad1 = new ClassifiedAd("Real Estate", 100, 50.0);
            Console.WriteLine($"Category: {ad1.Category}, Number of Words: {ad1.NumberOfWords}, Price: {ad1.Price}");

            ClassifiedAd ad2 = new ClassifiedAd("Automotive", 200, 75.0);
            Console.WriteLine($"Category: {ad2.Category}, Number of Words: {ad2.NumberOfWords}, Price: {ad2.Price}");
            
        }
    }
}