using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyFinance.Models
{
    public class Statistics
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public List<Spending> Spendings { get; set; }
        public Statistics()
        {
            
        }
        public Statistics(int month, int year)
        {
            Month = month;
            Year = year;
        }
    }
}
