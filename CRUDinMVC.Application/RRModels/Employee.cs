using CRUDinMVC.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Application.RRModels
{
    public class EmployeeRequest
    {
        [Required(ErrorMessage ="Enter The Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter The Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Select Gender")]
        public Gender Gender { get; set; }


        [Required(ErrorMessage = "Enter The Description")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Enter The Password")]
        public string Password { get; set; }


        [Compare(nameof(Password),ErrorMessage ="Password Does Not Match")]
        public string ConfirmPassword { get; set; }
    }

    public class EmployeeResponse
    {
        public Guid Id { get; set; }


        public string Name { get; set; }


        public string Email { get; set; }


        public Gender Gender { get; set; }


        public string Description { get; set; }


        public string Password { get; set; }
    }
}
