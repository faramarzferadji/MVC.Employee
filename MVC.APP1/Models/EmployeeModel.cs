using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC.APP1.Models
{
    public class EmployeeModel
    {
        [Display(Name="Employee ID")]
        [Range(1000000, 9999999)]
        public int EmployeeId { get; set; }
        [Display(Name="name")]
        [Required(ErrorMessage ="Pleas Enter th Name")]
        public string Name { get; set; }
        [Display(Name="Pass Word")]
        [Required(ErrorMessage ="PassWord Has to be 5 digits")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength =4, ErrorMessage = "PassWord Has to be 5 digits")]
        public string PassWord { get; set; }
        [Display(Name = "Confirm Pass Word")]
        [DataType(DataType.Password)]
        [Compare("PassWord", ErrorMessage ="cofirm your password")]

        public string ConfirmPassWord { get; set; }
    }
}