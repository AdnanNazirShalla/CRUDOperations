using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDinMVC.Domain.Entity
{
    public class Employees
    {
        public Guid Id { get; set; }


        public string Name { get; set; }


        public string Email { get; set; }


        public Gender Gender { get; set; }


        public string Description { get; set; }


        public string Password { get; set; }



    }
}
