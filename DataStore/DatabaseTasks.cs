
using System;
using System.Linq;

namespace dn_mvc_loc
{
    class DatabaseTasks
    {

        public void init()
        {
            deleteDb();
            createDbFromContext();
        }

        public void deleteDb()
        {
            using (var context = new DatabaseContext())
            {
                // The line below clears and resets the databse.
                context.Database.EnsureDeleted();
            }
        }

        static public void createDbFromContext()
        {
            using (var context = new DatabaseContext())
            {
                // Create the database if it does not exist
                context.Database.EnsureCreated();
            }
        }

        public void pushFakeData()
        {
            Console.WriteLine("Hello World Entity Framework Core!");

            using (var context = new DatabaseContext())
            {
                // Add some video games. 
                //Note that the Id field is autoincremented by default
                context.VideoGames.Add(new VideoGame
                {
                    Title = "Persona 5",
                    Platform = "PS4"
                });

                var SG = new VideoGame();
                SG.Title = "Steins's Gate";
                SG.Platform = "PSVita";
                context.VideoGames.Add(SG);


                var loc = new Location();
                loc.LocationId = 1;
                loc.HouseNum = "20";
                loc.City = "Glasgow";
                context.Locations.Add(loc);

                context.Items.Add(new Item
                {
                    LocationId = 1,
                    //Location = loc,
                    Description = "x box"
                });

                /*
                select it.*from Locations loc,Items it
                where loc.LocationId = it.LocationId
                and loc.City = 'Glasgow'
                */

                // Commit changes by calling save changes
                context.SaveChanges();

                // Fetch all video games
                Console.WriteLine("Current database content");
                foreach (var videoGame in context.VideoGames.ToList())
                {
                    Console.WriteLine($"{videoGame.Title} - {videoGame.Platform}");
                }




                // Fetch all PS4 games
                var ps4Games = from v in context.VideoGames
                               where v.Platform == "PS4"
                               select v;

                foreach (var videoGame in ps4Games)
                {
                    Console.WriteLine($"{videoGame.Title} - {videoGame.Platform}");
                }

                //delete ps4 games
                Console.WriteLine("Deleting PS4 Games");
                context.VideoGames.RemoveRange(ps4Games);




                //Do not forget to commit changes by calling save changes
                context.SaveChanges();
               

                Console.WriteLine("Current database content");
                foreach (var videoGame in context.VideoGames)
                {
                    Console.WriteLine($"{videoGame.Title} - {videoGame.Platform}");
                }
            }
        }
    }

}
