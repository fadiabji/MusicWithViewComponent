using Microsoft.AspNetCore.Mvc;
using MusicWithViewComponent.Models;
using MusicWithViewComponent.Services;
using System.Collections.Generic;

namespace MusicWithViewComponent.ViewComponents
{
    public class GetArtistAscViewComponent : ViewComponent
    {
        private readonly IArtistService _artistService;
        public GetArtistAscViewComponent(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public IViewComponentResult Invoke()
        {

            IEnumerable <Artist> listOfAllArtistAsc = _artistService.GetArtists();

            return View(listOfAllArtistAsc.OrderBy(a => a.Name));
        }


       
    }
}
