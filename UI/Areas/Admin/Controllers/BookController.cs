using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Common.Enums;
using Common.Search;
using BL;
using UI.Areas.Admin.Models;
using UI.Areas.Admin.Models.ViewModels;
using UI.Areas.Admin.Models.ViewModels.FilterModels;
using UI.Other;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = nameof(UserRole.Admin))]
	public class BookController : Controller
	{
		public async Task<IActionResult> Index(BookFilterModel bookFilterModel, int page = 1)
		{
			const int objectsPerPage = 20;
			var AuthorSearchResult = await new AuthorBL().GetAsync(new AuthorSearchParams
			{
				StartIndex = (page - 1) * objectsPerPage,
				ObjectsCount = objectsPerPage,
			});
			var AuthorViewModel = new SearchResultViewModel<AuthorModel>(AuthorModel.FromEntitiesList(AuthorSearchResult.Objects),
				AuthorSearchResult.Total, AuthorSearchResult.RequestedStartIndex, AuthorSearchResult.RequestedObjectsCount, 5);

			var Book_AuthorSearchResult = await new Book_AuthorBL().GetAsync(new Book_AuthorSearchParams
			{
				StartIndex = (page - 1) * objectsPerPage,
				ObjectsCount = objectsPerPage,
			});
			var Book_AuthorViewModel = new SearchResultViewModel<BookAuthorModel>(BookAuthorModel.FromEntitiesList(Book_AuthorSearchResult.Objects),
				Book_AuthorSearchResult.Total, Book_AuthorSearchResult.RequestedStartIndex, Book_AuthorSearchResult.RequestedObjectsCount, 5);
			var BookSearchResult = await new BookBL().GetAsync(new BookSearchParams
			{
				SearchQuery = bookFilterModel.SearchQuery,
				StartIndex = (page - 1) * objectsPerPage,
				ObjectsCount = objectsPerPage,
			});
			var BookViewModel = new SearchResultViewModel<BookModel, BookFilterModel>(BookModel.FromEntitiesList(BookSearchResult.Objects), bookFilterModel,
				BookSearchResult.Total, BookSearchResult.RequestedStartIndex, BookSearchResult.RequestedObjectsCount, 5);
			var PublisherSearchResult = await new PublisherBL().GetAsync(new PublisherSearchParams
			{
				StartIndex = (page - 1) * objectsPerPage,
				ObjectsCount = objectsPerPage,
			});
			var PublisherViewModel = new SearchResultViewModel<PublisherModel>(PublisherModel.FromEntitiesList(PublisherSearchResult.Objects),
				PublisherSearchResult.Total, PublisherSearchResult.RequestedStartIndex, PublisherSearchResult.RequestedObjectsCount, 5);
			var viewModel = new BookViewModel
			{
				author_Model = AuthorViewModel,
				book_author_Model = Book_AuthorViewModel,
				book_Model = BookViewModel,
				publisher_Model = PublisherViewModel
			};
			return View(viewModel);
		}

		public async Task<IActionResult> Update(int? id)
		{
			var model = new BookModel();
			if (id != null)
			{
				model = BookModel.FromEntity(await new BookBL().GetAsync(id.Value));
				if (model == null)
					return NotFound();
			}
			List<SelectListItem> Publisher = new List<SelectListItem>(); 

			var PublisherSearchResult = await new PublisherBL().GetAsync(new PublisherSearchParams());

			var PublisherViewModel = new SearchResultViewModel<PublisherModel>(PublisherModel.FromEntitiesList(PublisherSearchResult.Objects),
				PublisherSearchResult.Total, PublisherSearchResult.RequestedStartIndex, PublisherSearchResult.RequestedObjectsCount, 5);
			foreach (var i in PublisherViewModel.Objects)
			{
				Publisher.Add(new SelectListItem() { Text = i.Title.ToString(), Value = i.Id.ToString() });
			}
			ViewBag.Publisher = Publisher;
			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(BookModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			await new BookBL().AddOrUpdateAsync(BookModel.ToEntity(model));
			TempData[OperationResultType.Success.ToString()] = "Данные сохранены";
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Delete(int id)
		{
			var result = await new BookBL().DeleteAsync(id);
			if (result)
				TempData[OperationResultType.Success.ToString()] = "Объект удален";
			else
				TempData[OperationResultType.Error.ToString()] = "Объект не найден";
			return RedirectToAction("Index");
		}
	}
}
