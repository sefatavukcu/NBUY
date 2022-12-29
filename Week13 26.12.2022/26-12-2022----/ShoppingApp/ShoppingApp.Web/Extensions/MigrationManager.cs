﻿using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

namespace ShoppingApp.Web.Extensions
{
    public static class MigrationManager
    {
        public static IHost UpdateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var shopAppContext = scope.ServiceProvider.GetRequiredService<ShopAppContext>())
                {
                    try
                    {
                        shopAppContext.Database.Migrate(); // Bu komut henüz işlenmemiş migrationları alır ve dtabase update işlemine tabi tutar.
                    }
                    catch (Exception)
                    {
                        // hataların tutulduğu loglar burada hazırlanabilir.
                        throw;
                    }
                }
            }
            return host;
        }
    }
}