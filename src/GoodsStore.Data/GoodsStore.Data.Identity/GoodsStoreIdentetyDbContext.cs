using System;
using GoodsStore.Data.Identity.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoodsStore.Data.Identity
{
    public class GoodsStoreIdentetyDbContext : IdentityDbContext<GoodsStoreUser, GoodsStoreRole, string>
    {

        public GoodsStoreIdentetyDbContext(DbContextOptions<GoodsStoreIdentetyDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}