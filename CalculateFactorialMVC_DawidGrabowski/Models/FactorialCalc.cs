using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CalculateFactorialMVC_DawidGrabowski.Models
{
    public class FactorialCalc
    {
        [Required]
        [Display(Name = "Enter Your Number")]
        public int NumberInput { get; set; } // user input number - INTEGER

        [Display(Name = "Factorial is: ")]
        public long Result { get; set; } //this stores result


        public void CalculateFactorial()
        {
            if (NumberInput < 0)
            {
                throw new ArgumentException("Number must be higehr than 0!");
            }

            Result = CalculateFactorial(NumberInput);
        }

        private long CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}