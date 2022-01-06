using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.Applications.GenreOperations.Queries.GetGenres
{
    public class GetGenresQuery
    {
        private readonly BookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetGenresQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public  List<GenresViewModel> Handle()
        {
            var Genres = _context.Genres.Where(genre => genre.IsActive).OrderBy(genre => genre.Id);
            List<GenresViewModel> vm = _mapper.Map<List<GenresViewModel>>(Genres);
            return vm ;
        }
    }
    public class GenresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}