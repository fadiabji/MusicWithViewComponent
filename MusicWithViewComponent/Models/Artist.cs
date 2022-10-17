namespace MusicWithViewComponent.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public Artist()
        {

        }

        public Artist(int id, string name, string category)
        {
            Id = id;
            Name = name;
            Category = category;
        }

    }
}
