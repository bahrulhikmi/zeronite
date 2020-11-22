using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Zeronite.Infra.Books
{
    public class BookDataSeedContributor: IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepository;

        public BookDataSeedContributor(IRepository<Book, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
          if(await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Book
                    {
                        Name = "1984",
                        Type = BookType.Dystopia,
                        PublishDate = new DateTime(1949, 6, 8),
                        Price = 19.84f
                    }
                    );

                await _bookRepository.InsertAsync(
                   new Book
                   {
                       Name = "The Hitchhiker's Guide to the Galaxy",
                       Type = BookType.ScienceFiction,
                       PublishDate = new DateTime(1995, 9, 27),
                       Price = 42.0f
                   },
                   autoSave: true
               );
            }
        }
    }
}
