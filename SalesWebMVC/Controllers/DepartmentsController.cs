using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.ViewModels;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "eletronics" });
            list.Add(new Department { Id = 1, Name = "fashion" });

            return View(list);
        }
    }
}
