using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using static System.Net.WebRequestMethods;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }

        //[Route("")]
        //[Route("home")]
        //[Route("home/index")]
        //[AllowAnonymous]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployess();
            return View(model);
        }

        //[Route("home/details")]
        //[Route("home/details/{id?}")]
        public ViewResult Details(int id)
        {

            Employee employee = _employeeRepository.GetEmployee(id);
            if(employee == null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound",id);
            }

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                employee = employee,
                pagetitle = "employee details"
            };


            //HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            //{
            //    employee = _employeeRepository.GetEmployee(id??1),
            //    pagetitle = "employee details"
            //};

            //Employee employeedetails =  _employeeRepository.GetEmployee(1);
            //using ViewData
            //ViewData["pagetitle"] = "Employee Details";
            //ViewData["employee"] = model;

            //usingViewBag
            //ViewBag.pagetitle = "employee details";
            //ViewBag.employee = model;
            return View(homeDetailsViewModel);
        }

        [HttpGet]
        [Authorize(Roles ="admin")]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles ="admin")]
        public IActionResult Create(Employee employee)
        {
            if(ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Add(employee);
                return RedirectToAction("index");
            }
            return View();
            
        }

        [HttpGet]
        //[Authorize]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int id)
        {
            Employee model = _employeeRepository.GetEmployee(id);
            return View(model);
        }

        [HttpPost]
        //[Authorize]
        [Authorize(Roles = "admin")]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Employee UpdateEmployee = _employeeRepository.Update(employee);
                return RedirectToAction("index");
            }
            return View();
        }

        [Authorize(Roles ="admin")]
        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                Employee newEmployee = _employeeRepository.Delete(id);
                return RedirectToAction("index");
            }
            return View();

        }


       
        public IActionResult Import()
        {
            return View();
        }

        
        public async void ImportToExcel(IFormFile file)
        {
            var list = new List<Employee>();
            using(var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using( var package = new ExcelPackage(stream))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowcount = worksheet.Dimension.Rows;
                    for(int row=2; row<rowcount; row++)
                    {
                        list.Add(new Employee
                        {
                           Name  = worksheet.Cells[row, 1].Value.ToString().Trim(),
                           Email = worksheet.Cells[row, 2].Value.ToString().Trim()


                        });
                    }
                }
            }
            foreach(Employee e in list)
            {
                _employeeRepository.Add(e);
            }
           

        }


    }
}
