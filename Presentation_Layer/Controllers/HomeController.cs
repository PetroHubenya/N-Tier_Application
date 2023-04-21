using BLL;
using Common;
using Microsoft.AspNetCore.Mvc;
using Presentation_Layer.Models;
using System.Data;
using System.Diagnostics;

namespace Presentation_Layer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            StudentBLL studentBLL = new StudentBLL();
            StudentEntity student = new StudentEntity();

            // The application wouldn't build if I try to set StudentId.

            // student.StudentID = 6;

            DataTable dataTable = new DataTable();

            // DataTable studentDataTable = StudentBLL.GetStudentBelow5(student);
            

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}