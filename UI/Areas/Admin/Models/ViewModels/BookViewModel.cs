using UI.Areas.Admin.Models.ViewModels.FilterModels;

namespace UI.Areas.Admin.Models.ViewModels
{
	public class BookViewModel
	{
		public SearchResultViewModel<AuthorModel> author_Model { get; set; }
		public SearchResultViewModel<BookAuthorModel> book_author_Model { get; set; }
		public SearchResultViewModel<BookModel, BookFilterModel> book_Model { get; set; }
		public SearchResultViewModel<PublisherModel> publisher_Model { get; set; }
	}
}
