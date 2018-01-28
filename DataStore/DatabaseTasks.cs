
using System;
using System.Collections.Generic;
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

        public List<Item> getItems()
        {
            using (var context = new DatabaseContext())
            {
                //context.Database.
                return context.Items.ToList<Item>();

            }
        }

        public void pushFakeData()
        {
            Console.WriteLine("Hello World Entity Framework Core!");

            using (var context = new DatabaseContext())
            {
                var loc = new Location();
                loc.LocationId = 1;
                loc.HouseNum = "20";
                loc.City = "Glasgow";
                context.Locations.Add(loc);

                var item = new Item();
                item.ItemId = 1;
                item.Description = "ps4";
                context.Items.Add(item);

                var item2 = new Item();
                item2.ItemId = 2;
                item2.Description = "ps3";
                context.Items.Add(item2);
               
                // Commit changes by calling save changes
                context.SaveChanges();
            }
        }
    }

}
