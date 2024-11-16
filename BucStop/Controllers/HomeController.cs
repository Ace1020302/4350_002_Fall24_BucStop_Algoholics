using BucStop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection;

/*
 * This file has the controllers for everything outside of the games
 * and game-related pages.
 */

namespace BucStop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GameService _gameService;
        private readonly IWebHostEnvironment _environment;
        private static readonly HttpClient _httpClient = new HttpClient();

        public HomeController(ILogger<HomeController> logger, GameService games)
        {
            _logger = logger;
            _gameService = games;
        }

        //Sends the user to the deprecated Index page.
        public IActionResult Index()
        {
            return View(_gameService.GetGames());
        }

        //Takes the user to the admin page.
        public IActionResult Admin()
        {
            return View();
        }

        //Takes the user to the about policy page.
        public IActionResult Privacy()
        {
            return View();
        }

        //Takes the user to the game criteria page.
        public IActionResult GameCriteria()
        {
            return View();
        }

        //Takes the user to version 2.1 page
        public IActionResult TwoDotOne()
        {
            return View();
        }

        public IActionResult TwoDotTwo()
        {
            return View();
        }

        public IActionResult TwoDotThree()
        {
            return View();
        }

        public IActionResult TwoDotFour()
        {
            return View();
        }

        //If something goes wrong, this will take the user to a page explaining the error.
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Submit(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var fileExtension = Path.GetExtension(file.FileName).ToLower();
                // Check if the file is a JavaScript file
                if (fileExtension != ".js")
                {
                    // Return an error message if the file is not a JavaScript file
                    TempData["Message"] = "Only JavaScript (.js) files are allowed.";
                    return RedirectToAction("GameCriteria", "Home");
                }

                HttpContent fileStreamContent = new StreamContent(file.OpenReadStream());

                using (var formData = new MultipartFormDataContent())
                {
                    formData.Add(fileStreamContent, "file1", "file1");

                    var response = await _httpClient.PostAsync("https://localhost:32768/api/Submission", formData);

                    if (response.IsSuccessStatusCode)
                    {
                        // Return a success message
                        TempData["Message"] = "File uploaded successfully!";
                    }
                    else
                    {
                        //return an error message
                        TempData["Message"] = response.ToString();
                    }
                }
            }
            return RedirectToAction("GameCriteria", "Home");
        }
    }
}