using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class SurveyController : Controller
{
    private readonly SurveyContext _context;

    public SurveyController(SurveyContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Submit(Survey survey)
    {
        if (ModelState.IsValid)
        {
            _context.Surveys.Add(survey);
            _context.SaveChanges();
            ViewBag.SuccessMessage = "Survey submitted successfully!";
            ViewBag.FormSubmitted = true;
            return View("Index");
        }
        ViewBag.FormSubmitted = false;
        return View("Index", survey);
    }

    public IActionResult Results()
    {
        var surveys = _context.Surveys.ToList();

        if (surveys.Count == 0)
        {
            ViewBag.Message = "No Surveys Available.";
            return View();
        }

        var totalSurveys = surveys.Count;
        var averageAge = surveys.Average(s => DateTime.Now.Year - s.DateOfBirth.Year);

        var oldestPersonDob = surveys.Min(s => s.DateOfBirth);
        var youngestPersonDob = surveys.Max(s => s.DateOfBirth);

        var oldestPersonAge = DateTime.Now.Year - oldestPersonDob.Year;
        var youngestPersonAge = DateTime.Now.Year - youngestPersonDob.Year;

        var pizzaLovers = surveys.Count(s => s.LikesPizza);
        var pizzaPercentage = (double)pizzaLovers / totalSurveys * 100;
        var eatOutAverage = surveys.Average(s => s.EatOutRating);

        ViewBag.TotalSurveys = totalSurveys;
        ViewBag.AverageAge = averageAge;
        ViewBag.OldestPersonAge = oldestPersonAge;
        ViewBag.YoungestPersonAge = youngestPersonAge;
        ViewBag.PizzaPercentage = Math.Round(pizzaPercentage, 1);
        ViewBag.EatOutAverage = Math.Round(eatOutAverage, 1);

        return View(surveys);
    }
}
