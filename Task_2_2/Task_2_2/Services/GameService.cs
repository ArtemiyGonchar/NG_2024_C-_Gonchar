using PagedList;
using Task_2_2.Data;
using Task_2_2.Models;
namespace Task_2_2.Services
{
    internal class GameService
    {
        private List<Game> game;
        private DataSource dataSource;
        public Game GetById(int id)
        {
            return DataSource.Games.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Game> GetByPrice()
        {
            return DataSource.Games.OrderBy(game => game.Price);
        }

        public IEnumerable<Genre> GetGenres(string name)
        {
            //return (IEnumerable<Genre>)DataSource.Games.Where(x => x.Name == name);
            var game = DataSource.Games.FirstOrDefault(game => game.Name == name);
            return game.Genres;
        }

        public IEnumerable<string> GetUniqueCategory()
        {
            return DataSource.Games.Select(game => game.Category).Distinct();
        }

        public IEnumerable<Game> FilterByCategoriesNGenres(List<string> genres)
        {
            return DataSource.Games.Where(game => game.Genres.Any(genre => genres.Contains(genre.Name)));
        }

        public IEnumerable<Game> GetGamesByPages(int page)
        {
            int pageSize = 5;
            return DataSource.Games.ToPagedList(page, pageSize);
        }
    }
}
