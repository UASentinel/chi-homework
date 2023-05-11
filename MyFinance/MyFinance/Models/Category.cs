using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace MyFinance.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Validate(ModelStateDictionary modelState)
        {
            var result = true;

            if (Name == null || (Name != null && Name.Count() > 50))
            {
                modelState.AddModelError("Name", "Invalid Name");
                result = false;
            }

            return result;
        }
    }
}
