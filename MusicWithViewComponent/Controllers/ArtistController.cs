using Microsoft.AspNetCore.Mvc;
using MusicWithViewComponent.Models;

namespace MusicWithViewComponent.Controllers
{
    public class ArtistController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }

    }
}
