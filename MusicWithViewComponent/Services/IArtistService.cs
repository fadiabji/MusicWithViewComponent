using MusicWithViewComponent.Models;

namespace MusicWithViewComponent.Services
{
    public interface IArtistService
    {
        IEnumerable<Artist> GetArtists();

    }
}
