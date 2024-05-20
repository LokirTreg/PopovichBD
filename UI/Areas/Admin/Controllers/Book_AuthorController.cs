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
using UI.Other;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Authorize(Roles = nameof(UserRole.Admin))]
	public class Book_AuthorController : Controller
	{
		public async Task<IActionResult> Index(int page = 1)
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
				StartIndex = (page - 1) * objectsPerPage,
				ObjectsCount = objectsPerPage,
			});
			var BookViewModel = new SearchResultViewModel<BookModel>(BookModel.FromEntitiesList(BookSearchResult.Objects),
				BookSearchResult.Total, BookSearchResult.RequestedStartIndex, BookSearchResult.RequestedObjectsCount, 5);
			var viewModel = new AuthorBookViewModel
			{
				author_Model = AuthorViewModel,
				book_author_Model = Book_AuthorViewModel,
				book_Model = BookViewModel
			};
			return View(viewModel);
		}

		public async Task<IActionResult> Update(int? id)
		{
			var model = new BookAuthorModel();
			if (id != null)
			{
				model = BookAuthorModel.FromEntity(await new Book_AuthorBL().GetAsync(id.Value));
				if (model == null)
					return NotFound();
			}


			List<SelectListItem> IdBook = new List<SelectListItem>();

			var IdBookSearchResult = await new BookBL().GetAsync(new BookSearchParams());

			var IdBookViewModel = new SearchResultViewModel<BookModel>(BookModel.FromEntitiesList(IdBookSearchResult.Objects),
				IdBookSearchResult.Total, IdBookSearchResult.RequestedStartIndex, IdBookSearchResult.RequestedObjectsCount, 5);
			foreach (var i in IdBookViewModel.Objects)
			{
				IdBook.Add(new SelectListItem() { Text = i.Title.ToString(), Value = i.Id.ToString() });
			}
			ViewBag.IdBook = IdBook;

			List<SelectListItem> IdAuthor = new List<SelectListItem>();

			var IdAuthorSearchResult = await new AuthorBL().GetAsync(new AuthorSearchParams());

			var IdAuthorViewModel = new SearchResultViewModel<AuthorModel>(AuthorModel.FromEntitiesList(IdAuthorSearchResult.Objects),
				IdAuthorSearchResult.Total, IdAuthorSearchResult.RequestedStartIndex, IdAuthorSearchResult.RequestedObjectsCount, 5);
			foreach (var i in IdAuthorViewModel.Objects)
			{
				IdAuthor.Add(new SelectListItem() { Text = i.Name.ToString(), Value = i.Id.ToString() });
			}
			ViewBag.IdAuthor = IdAuthor;

			return View(model);
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Update(BookAuthorModel model)
		{
			if (!ModelState.IsValid)
			{
				return View(model);
			}
			await new Book_AuthorBL().AddOrUpdateAsync(BookAuthorModel.ToEntity(model));
			TempData[OperationResultType.Success.ToString()] = "Данные сохранены";
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> Delete(int id)
		{
			var result = await new Book_AuthorBL().DeleteAsync(id);
			if (result)
				TempData[OperationResultType.Success.ToString()] = "Объект удален";
			else
				TempData[OperationResultType.Error.ToString()] = "Объект не найден";
			return RedirectToAction("Index");
		}
	}
}
