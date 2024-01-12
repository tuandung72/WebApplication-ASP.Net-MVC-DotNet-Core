using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_MVC_TH_01.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            var studentModel = new StudentModel
            {
                FullName = "Nguyen Van A",
                StudentID = "123456",
                Address = "Hanoi, Vietnam",
                Email = "nguyenvana@example.com",
                Hobbies = "Reading, Coding"
            };

            return View(studentModel);
        }
    }
}