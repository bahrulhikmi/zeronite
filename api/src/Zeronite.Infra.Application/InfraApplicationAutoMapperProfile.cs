using AutoMapper;
using Zeronite.Infra.Books;

namespace Zeronite.Infra
{
    public class InfraApplicationAutoMapperProfile : Profile
    {
        public InfraApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>();
        }
    }
}
