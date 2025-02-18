﻿using dotnetQ.Abstractions.Storage;
using dotnetQ.Storage.EntityFrameworkCore.SqlServer.DbCtxs;

namespace dotnetQ.Storage.EntityFrameworkCore.SqlServer.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly QPrimaryDbContext _primaryDbContext;
    private readonly QReadonlyDbContext _readonlyDbContext;

    public ItemRepository(
        QPrimaryDbContext primaryDbContext,
        QReadonlyDbContext readonlyDbContext)
    {
        _primaryDbContext = primaryDbContext;
        _readonlyDbContext = readonlyDbContext;
    }

    #region Queries
    #endregion

    #region Commands
    #endregion
}