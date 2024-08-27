using Task_2_2.Models;
namespace Task_2_2.Data
{
    internal class DataSource
    {
        public static IEnumerable<Game> Games { get; set; } = new List<Game>()
        {
            new()
            {
                Id = 1,
                Name = "Minecraft",
                Price = 20,
                Category = "Sandbox",
                Genres = new List<Genre>
                {
                    new () { Name = "Survival", Description = "Survive."},
                    new () { Name = "Building", Description = "Build."},
                    new () { Name = "Crafting", Description = "Craft."}
                }
            },
            new()
            {
                Id = 2,
                Name = "Counter-Strike 2",
                Price = 8,
                Category = "Action",
                Genres = new List<Genre>
                {
                    new () { Name = "Shooter", Description = "Shoot."},
                    new () { Name = "Strategy", Description = "Do some strategy."},
                    new () { Name = "FPS", Description = "First Person Shooter"}
                }
            },
            new()
            {
                Id = 3,
                Name = "Dota 2",
                Price = 0,
                Category = "MOBA",
                Genres = new List<Genre>
                {
                    new () { Name = "Strategy", Description = "Do some strategy."},
                    new () { Name = "Co-op", Description = "Play with people in team."},
                    new () { Name = "Hard", Description = "It's hard."}
                }
            },
            new()
            {
                Id = 4,
                Name = "Dark Souls 3",
                Price = 20,
                Category = "Action",
                Genres = new List<Genre>
                {
                    new () { Name = "Hard", Description = "It's hard."},
                    new () { Name = "Dark-fantasy", Description = "It's dark and it's fantasy."},
                    new () { Name = "Adventure", Description = "Hop on adventure."}
                }
            },
            new()
            {
                Id = 5,
                Name = "Elden Ring",
                Price = 70,
                Category = "Action",
                Genres = new List<Genre>
                {
                    new () { Name = "Hard", Description = "It's hard."},
                    new () { Name = "Open-world", Description = "Like real one."},
                    new () { Name = "Adventure", Description = "Hop on adventure."}
                }
            },
            new()
            {
                Id = 6,
                Name = "Red Dead Redemption",
                Price = 20,
                Category = "Story",
                Genres = new List<Genre>
                {
                    new () { Name = "Open-world", Description = "Like real one."},
                    new () { Name = "Adventure", Description = "Hop on adventure."},
                    new () { Name = "Story", Description = "Some stories."}
                }
            },
            new()
            {
                Id = 7,
                Name = "Space Engineers",
                Price = 15,
                Category = "Sandbox",
                Genres = new List<Genre>
                {
                    new () { Name = "Space", Description = "YEEAH SPAACE."},
                    new () { Name = "Building", Description = "Build."},
                    new () { Name = "Crafting", Description = "Craft."}
                }
            },
            new()
            {
                Id = 8,
                Name = "Warcraft 3: The Frozen Throne",
                Price = 20,
                Category = "RTS",
                Genres = new List<Genre>
                {
                    new () { Name = "Strategy", Description = "Do some strategy."},
                    new () { Name = "Hard", Description = "It's hard."},
                    new () { Name = "Story", Description = "Some stories."}
                }
            },
            new()
            {
                Id = 9,
                Name = "Lego Star Wars 2",
                Price = 4,
                Category = "Fun",
                Genres = new List<Genre>
                {
                    new () { Name = "Space", Description = "YEEAH SPAACE."},
                    new () { Name = "Adventure", Description = "Hop on adventure."},
                    new () { Name = "Co-op", Description = "Play with people in team."}
                }
            },
            new()
            {
                Id = 10,
                Name = "Baldur's Gate 3",
                Price = 20,
                Category = "Role-play",
                Genres = new List<Genre>
                {
                    new () { Name = "Adventure", Description = "Hop on adventure."},
                    new () { Name = "Co-op", Description = "Play with people in team."},
                    new () { Name = "Story", Description = "Some stories."}
                }
            }
        };
    }
}
