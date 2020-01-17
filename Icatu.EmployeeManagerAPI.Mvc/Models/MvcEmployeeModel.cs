using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Icatu.EmployeeManagerAPI.Mvc.Models
{
    public class MvcEmployeeModel
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(250, ErrorMessage="Maximum size allowed: 250")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(150, ErrorMessage = "Maximum size allowed: 150")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Required field")]
        [MaxLength(150, ErrorMessage = "Maximum size allowed: 150")]
        public string Email { get; set; }
    }
}