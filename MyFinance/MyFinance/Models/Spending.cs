using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyFinance.Models
{
    public class Spending
    {
        public int Id { get; set; }
        public decimal Sum { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }
        public bool Validate(ModelStateDictionary modelState)
        {
            var result = true;

            if(Sum <= 0)
            {
                modelState.AddModelError("Sum", "Invalid Sum");
                result = false;
            }

            if (DateTime == null || DateTime <= new DateTime(2000, 01, 01) || DateTime > DateTime.Now.AddMinutes(1))
            {
                modelState.AddModelError("DateTime", "Invalid DateTime");
                result = false;
            }

            return result;
        }
    }
}
