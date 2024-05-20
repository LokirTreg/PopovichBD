﻿using System;
using System.Collections.Generic;
using Common.Enums;

namespace Common.Search
{
	public class Book_GenreSearchParams : BaseSearchParams
	{
		public Book_GenreSearchParams(int startIndex = 0, int? objectsCount = null) : base(startIndex, objectsCount)
		{
		}
	}
}
