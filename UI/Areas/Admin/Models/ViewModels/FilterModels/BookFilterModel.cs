using System.ComponentModel.DataAnnotations;

namespace UI.Areas.Admin.Models.ViewModels.FilterModels
{
	public class BookFilterModel : BaseFilterModel
	{
		[Display(Name = "Поисковый запрос")]
		public string SearchQuery { get; set; }
	}
}
