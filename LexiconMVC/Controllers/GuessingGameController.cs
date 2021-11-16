using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC.Controllers
{
    public class GuessingGameController : Controller
    {
        public IActionResult Index()
        {

            if(HttpContext.Session.GetInt32("numberToGuess") == 0 || HttpContext.Session.GetInt32("numberToGuess") == null)
            {
                var rand = new Random();
                int randomNumber = rand.Next(1, 101);
                HttpContext.Session.SetInt32("numberToGuess", randomNumber);
                HttpContext.Session.SetInt32("numberOfGuesses", 0);
            }

            ViewBag.Msg = HttpContext.Session.GetString("guessMessage");
            ViewBag.NumberOfGuesses = HttpContext.Session.GetInt32("numberOfGuesses");

            return View();
        }

        [HttpPost]
        public ActionResult Index(string number)
        {
            Int32.TryParse(number, out int guessedNum);

            // guess was lower than the number to guess
            if (HttpContext.Session.GetInt32("numberToGuess") > guessedNum)
                HttpContext.Session.SetString("guessMessage", "Your guess was to low, guess again.");

            // guess was higher than the number to guess
            if (HttpContext.Session.GetInt32("numberToGuess") < guessedNum)
                HttpContext.Session.SetString("guessMessage", "Your guess was to high, guess again.");

            // Guess was correct
            if (HttpContext.Session.GetInt32("numberToGuess") == guessedNum)
            {
                HttpContext.Session.SetString("guessMessage" ,"Congratualtions you guessed the right number");
                HttpContext.Session.SetInt32("numberToGuess", 0);
            }

            int numOfGuesses = (int)HttpContext.Session.GetInt32("numberOfGuesses");
            HttpContext.Session.SetInt32("numberOfGuesses", ++numOfGuesses);

            return RedirectToAction(nameof(Index));
        }
    }
}
