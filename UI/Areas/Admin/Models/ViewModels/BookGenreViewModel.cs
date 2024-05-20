namespace UI.Areas.Admin.Models.ViewModels
{
	public class BookGenreViewModel
	{
		public SearchResultViewModel<GenreModel> genre_Model { get; set; }
		public SearchResultViewModel<BookGenreModel> book_genre_Model { get; set; }
		public SearchResultViewModel<BookModel> book_Model { get; set; }
	}
}
