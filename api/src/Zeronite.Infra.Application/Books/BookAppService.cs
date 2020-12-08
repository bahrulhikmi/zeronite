using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Zeronite.Infra.Permissions;

namespace Zeronite.Infra.Books
{
    public class BookAppService :
         CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>, //Used to create/update a book
          IBookAppService
    {
        public BookAppService(IRepository<Book, Guid> repository): base(repository)
        {
            GetPolicyName = InfraPermissions.Books.Default;
            GetListPolicyName = InfraPermissions.Books.Default;
            CreatePolicyName = InfraPermissions.Books.Create;
            UpdatePolicyName = InfraPermissions.Books.Edit;
        }

      
    }
}
