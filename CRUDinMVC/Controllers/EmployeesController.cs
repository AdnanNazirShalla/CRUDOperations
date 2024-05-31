using CRUDinMVC.Application.Abstractions.IServices;
using CRUDinMVC.Application.RRModels;
using Microsoft.AspNetCore.Mvc;

namespace CRUDinMVC.Controllers
{
    [Route("Employees")]
    public class EmployeesController : Controller
    {
        private readonly IEmployeeService service;

        public EmployeesController(IEmployeeService service)
        {
            this.service = service;
        }

        [HttpGet("Add")]
        public IActionResult AddEmployee()
        {
            ViewBag.Success = "";
            return View();
        }

        [HttpPost("Add")]
        public IActionResult AddEmployee(EmployeeRequest model)
        {
            var res = service.AddEmployee(model);
            if (res > 0)
            {
                ViewBag.Success = "Employee Added Successfully";
            }
            else
            {
                ViewBag.Error = "There Is Some Error Please Try After Sometime";
            }
            return View();
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            return View(service.GetEmployees());
        }

        [HttpGet("update/{id:guid}")]
        public IActionResult UpdateEmployee(Guid id)
        {
            return View(service.GetEmployeeById(id));
        }

        [HttpPost("update/{id:guid}")]
        public IActionResult UpdateEmployee(EmployeeResponse model)
        {
           var res= service.UpdateEmployee(model);

            if (res > 0)
            {
                ViewBag.Success = "Employee Added Successfully";
                return RedirectToAction(nameof(GetEmployees));
            }
            else
            {
                ViewBag.Error = "There Is Some Error Please Try After Sometime";
            }
            return View();
        }

        [HttpGet("{id:guid}")]
        public IActionResult DeleteEmployee(Guid id)
        {
            var res = service.DeleteEmployee(id);
            if (res > 0)
            {
                ViewBag.Success = "Employee Added Successfully";
            }
            else
            {
                ViewBag.Error = "There Is Some Error Please Try After Sometime";
            }
            return RedirectToAction(nameof(GetEmployees));

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
