using System;
using Microsoft.AspNetCore.Mvc;

namespace DataAnalysis.Controllers
{
    public partial class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
