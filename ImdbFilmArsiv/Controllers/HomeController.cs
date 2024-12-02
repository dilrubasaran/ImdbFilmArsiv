using ImdbFilmArsiv.Models;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new MovieViewModel
        {
            Title = "Spider-Man No Way Home",
            Year = 2021,
            Duration = 148,
            Category = "Action",
            Description = "From DC Comics comes the Suicide Squad, an antihero team of incarcerated supervillains who act as deniable assets for the United States government, undertaking high-risk black ops missions in exchange for commuted prison sentences.",
            ImagePathBanner = "/images/spidermanafis.png",
            ImagePathCover = "/images/spiderman_film_kapak.png"
        };

        return View(model);
    }
}
