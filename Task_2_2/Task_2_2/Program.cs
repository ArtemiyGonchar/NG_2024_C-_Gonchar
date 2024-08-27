using Task_2_2.Data;
using Task_2_2.Services;
namespace Task_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storages = DataSource.Games;
            GameService service = new GameService();
            int exit = 0;

            Console.WriteLine("\t\tCOMMANDS\n" +
                "id - get one game by id.\n" +
                "price - get a list in price range.\n" +
                "genres - get a list of genres by a game.\n" +
                "unique - get uniquie categories from game list.\n" +
                "filter - get all games that have at least one of these genres on a list.\n" +
                "page - page for games.\n" +
                "exit - exit from program.\n");

            while (true)
            {
                if (exit == 1)
                {
                    break;
                }

                Console.Write("Enter command: ");
                string action = Console.ReadLine().ToString();
                Console.Clear();

                switch (action)
                {
                    case "id":
                        Console.Write("Enter Id: ");
                        int inputId = (int)long.Parse(Console.ReadLine().ToString());
                        Console.WriteLine(service.GetById(inputId).Name);
                        break;

                    case "page":

                        Console.Write("Enter page: ");
                        int inputPage = (int)long.Parse(Console.ReadLine().ToString());
                        var gamePage = service.GetGamesByPages(inputPage);
                        foreach (var info in gamePage)
                        {
                            Console.WriteLine($"Name - {info.Name}\n" +
                                $"Id - {info.Id}\n" +
                                $"Price - {info.Price}\n" +
                                $"Category - {info.Category}\n\n" +
                                $"Genres: ");
                            foreach (var genre in info.Genres)
                            {
                                Console.WriteLine($"Genre name - {genre.Name}\n" +
                                    $"Genre description:\n" +
                                    $"{genre.Description}");
                            }
                            Console.WriteLine("----------");

                        }
                        break;
                    case "genres":
                        Console.Write("Enter game: ");
                        string inputGame = Console.ReadLine().ToString();
                        var genres = service.GetGenres(inputGame);
                        foreach (var genre in genres)
                        {
                            Console.WriteLine(genre.Name);
                        }
                        break;
                    case "unique":
                        var uniqueCategories = service.GetUniqueCategory();
                        foreach (var genre in uniqueCategories) { Console.WriteLine(genre); }
                        break;

                    case "filter":
                        List<string> inputGenres = new List<string>();
                        while (true)
                        {
                            Console.Write("Enter genres: ");
                            string inputGenre = Console.ReadLine().ToString();

                            if (string.IsNullOrEmpty(inputGenre))
                            {
                                break;
                            }

                            inputGenres.Add(inputGenre);

                        }

                        var gotGames = service.FilterByCategoriesNGenres(inputGenres);

                        foreach (var g in gotGames)
                        {
                            Console.WriteLine(g.Name);
                        }
                        break;

                    case "price":
                        foreach (var gameByPrice in service.GetByPrice())
                        {
                            Console.WriteLine(gameByPrice.Name);
                        }
                        break;
                    case "exit":
                        exit = 1;
                        break;
                }
            }
        }
    }
}
