﻿namespace MSBase.Core.Application.Queries;

public class PagedQueryResult<TResultItem> : QueryResult where TResultItem : IPagedQueryResultItem
{
    public IEnumerable<TResultItem> Result { get; set; }
    public IQueryPaginationResult Pagination { get; set; }
}