/*
 The code defines a controller class named HomeController in an ASP.NET Core MVC application. 
This controller is responsible for handling requests related to the home page and privacy policy, as well as managing error responses.
 */
using System.Diagnostics;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CRUD.Controllers
{
    // The HomeController class is declared within the CRUD.Controllers namespace.
    // This helps organize the code and avoid naming conflicts with other classes.
    //The class inherits from Controller, which is the base class for all controllers in ASP.NET Core MVC.
    public class HomeController : Controller
    {
        // This private field is of type ILogger<HomeController>, which is an interface for logging. It allows the controller to log messages, warnings, errors, etc.
        // The HomeController type is specified as a generic type parameter, which helps categorize the logs.
        private readonly ILogger<HomeController> _logger;

        // The constructor takes a parameter of type ILogger<HomeController>, which is provided by dependency injection. This allows the controller to use the logger for logging purposes.
        // The logger is assigned to the private field _logger.
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // The Index action method handles HTTP GET requests to the root URL (e.g., /).
        //It returns a view, which is typically the home page of the application.
        //The View() method looks for a view file named Index.cshtml in the appropriate views folder.
        public IActionResult Index()
        {
            return View();
        }

        // The Privacy action method handles HTTP GET requests to the /Home/Privacy URL.
        //It returns a view, which is typically a privacy policy page.The View() method looks for a view file named Privacy.cshtml.
        public IActionResult Privacy()
        {
            return View();
        }
        /* The Error action method handles error responses. It is decorated with the [ResponseCache] attribute, which configures caching behavior for the response:
        Duration = 0: No caching duration.
        Location = ResponseCacheLocation.None: The response should not be cached.
        NoStore = true: The response should not be stored in any cache.

                [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
