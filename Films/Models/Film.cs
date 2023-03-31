namespace Films.Models
{
    public class Film
    {
        public Guid FilmId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Geners { get; set; }
        public string Description { get; set; }
    }
}
