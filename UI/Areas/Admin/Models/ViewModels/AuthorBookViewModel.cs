namespace UI.Areas.Admin.Models.ViewModels
{
	public class AuthorBookViewModel
	{
		public SearchResultViewModel<AuthorModel> author_Model { get; set; }
		public SearchResultViewModel<BookAuthorModel> book_author_Model { get; set; }
		public SearchResultViewModel<BookModel> book_Model { get; set; }
	}
}
