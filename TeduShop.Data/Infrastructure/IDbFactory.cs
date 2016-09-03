using System;
using TeduShop.Data;

namespace TeduShop.Common.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}