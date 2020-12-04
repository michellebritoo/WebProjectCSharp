using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BritoWebMVC.Services;

namespace BritoWebMVC.Controllers
{
    public class SallesRecordsController : Controller
    {
        private readonly SallesRecordService _sallesRecordService;

        public SallesRecordsController(SallesRecordService sallesRecordService)
        {
            _sallesRecordService = sallesRecordService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimplesSearch(DateTime ? minDate, DateTime ? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!maxDate.HasValue)
            {
                maxDate = new DateTime(DateTime.Now);
            }

            ViewData["minDate"] = minDate.Value.ToString("dd/mm/aaaa");
            ViewData["maxDate"] = maxDate.Value.ToString("dd/mm/aaaa");
            var result = await _sallesRecordService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }

    }
}
