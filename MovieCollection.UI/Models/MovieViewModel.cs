namespace MovieCollection.UI.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int DirectorId { get; set; }
        public DirectorViewModel Director { get; set; }
        public int CountryId { get; set; }
        public CountryViewModel Country { get; set; }
        public int GenreId { get; set; }
        public CountryViewModel Genre { get; set; }
        //public IEnumerable<GenreViewModel> Genres { get; set; }
    }
}
