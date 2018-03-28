using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Localization_Tutorial_MVC.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Display(Name = "Name", ResourceType = typeof(Resources.Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
              ErrorMessageResourceName = "NameRequiredError")]
        public string Name { get; set; }

        [Display(Name = "Age", ResourceType = typeof(Resources.Resources))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resources),
              ErrorMessageResourceName = "AgeRequiredError")]
        public int Age { get; set; }
    }
}