using FastFood.Models;
using FastFood.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Diagnostics;

namespace FastFood.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataConnection _dataConnection;
        public HomeController(IDataConnection dataConnection)
        {
            _dataConnection = dataConnection;
        }

        public async Task<IActionResult> Index()
        {
            List<Employee> result = await _dataConnection.GetAllEmployee();
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePost(Employee newEmployee)
        {
            if (ModelState.IsValid)
            {
                await _dataConnection.AddNewEmployee(newEmployee);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}