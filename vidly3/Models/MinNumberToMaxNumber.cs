using System.ComponentModel.DataAnnotations;

namespace vidly3.Models
{
    public class MinNumberToMaxNumber : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext){
            var movie = (Movie)validationContext.ObjectInstance;
            if (movie.NumberInStock>= 1 && movie.NumberInStock<= 20)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Number must be between 1..20");
            }
           
        }
    }
}
