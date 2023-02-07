using AndreysPortfolio.EmailService;
using AndreysPortfolio.Interfaces;
using AndreysPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AndreysPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProjects _projects;

        public HomeController(IProjects projects)
        {
            _projects = projects;
        }

        public IActionResult Index()
        {
            var project = _projects.GetProjects();
            return View(project);
        }

        public IActionResult FillInForm()
        {
            return View();
        }

        public IActionResult HandleRequest(Request request)
        {
            var emailSender = new EmailSender();
            var message = $"{request.Name} \n {request.PhoneNumber} \n {request.Message}";
            emailSender.SendEmailAsync("qzw299@yandex.ru", "request", message);

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}