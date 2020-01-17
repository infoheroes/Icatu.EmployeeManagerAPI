using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Icatu.EmployeeManagerAPI.WebApi.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(150)]
        public string Department { get; set; }

        [Required]
        [StringLength(150)]
        public string Email { get; set; }
    }
}