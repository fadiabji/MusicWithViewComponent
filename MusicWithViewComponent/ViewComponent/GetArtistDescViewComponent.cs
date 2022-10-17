using Microsoft.AspNetCore.Mvc;
using MusicWithViewComponent.Models;
using MusicWithViewComponent.Services;
using System.Collections.Generic;

namespace MusicWithViewComponent.ViewComponents
{
    public class GetArtistDescViewComponent : ViewComponent
    {
        private readonly IArtistService _artistService;
        public GetArtistDescViewComponent(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public IViewComponentResult Invoke()
        {

            IEnumerable <Artist> listOfAllArtistAsc = _artistService.GetArtists();

            return View(listOfAllArtistAsc.OrderByDescending(a => a.Name));
        }
    }
}
