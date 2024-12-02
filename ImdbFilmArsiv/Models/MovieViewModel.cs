namespace ImdbFilmArsiv.Models
{
	public class MovieViewModel
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public int  Year { get; set; }
		public int  Duration { get; set; }
		public string Category { get; set; }
		public string Description { get; set; }
		public string ImagePathBanner { get; set; }
        public string ImagePathCover { get; set; }

    }
}
