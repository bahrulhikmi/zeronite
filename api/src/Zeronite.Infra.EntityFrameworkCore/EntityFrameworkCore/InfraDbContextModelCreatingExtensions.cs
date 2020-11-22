using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Zeronite.Infra.Books;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Zeronite.Infra.EntityFrameworkCore
{
    public static class InfraDbContextModelCreatingExtensions
    {
        public static void ConfigureInfra(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Book>(b =>
            {
                b.ToTable(InfraConsts.DbTablePrefix + "Books", InfraConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                //...
            });
        }
    }
}