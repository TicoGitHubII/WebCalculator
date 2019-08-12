using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebCalculator.Models
{
    public class Operation
    {

        [Required]
        [Display(Name = "First Number")]
        [RegularExpression("(\\+|-)?\\d+", ErrorMessage = "Numbers Only")]
        public float Left { get; set; }

        [Required]
        [Display(Name = "Second Number")]
        [RegularExpression("(\\+|-)?\\d+", ErrorMessage = "Numbers Only")]
        public float Right { get; set; }

        [Display(Name = "Result Number")]
        public float Result { get; set; }


        [Display(Name = "Operator")]
        public Operator Operator { get; set; }



    }
}
