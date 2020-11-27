using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BritoWebMVC.Models;

namespace BritoWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
   
        public IActionResult Index()
        {
            List<Department> lista = new List<Department>();
            lista.Add(new Department { Id = 1, Name = "Eletronicos" });
            lista.Add(new Department { Id = 1, Name = "Moda" });

            return View(lista);
        }
    }
}
