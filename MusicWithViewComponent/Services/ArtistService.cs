using MusicWithViewComponent.Models;

namespace MusicWithViewComponent.Services
{
    public class ArtistService : IArtistService
    {

        public IEnumerable<Artist> GetArtists()
        {

            List<Artist> artistsList = new List<Artist>()
            {
                new Artist(1,"Justin Bieber", "pop"),
                new Artist(2, "Well Smith", "rock"),
                new Artist(3,"Eddie Sheran", "pop"),
                new Artist(4, "Micheal Jackson", "pop"),
                new Artist(5, "Bob Marley", "reggea"),
                new Artist(6, "Iron Maiden", "hard rock"),
            };

            return artistsList;
        }

    }
}
