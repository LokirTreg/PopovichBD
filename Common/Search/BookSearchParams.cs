using System;
using System.Collections.Generic;
using Common.Enums;
using MailKit.Search;

namespace Common.Search
{
	public class BookSearchParams : BaseSearchParams
	{
		public string SearchQuery { get; set; }
		public BookSearchParams(int startIndex = 0, string searchQuery=null, int? objectsCount = null) : base(startIndex, objectsCount)
		{
			SearchQuery = searchQuery;
		}
	}
}
