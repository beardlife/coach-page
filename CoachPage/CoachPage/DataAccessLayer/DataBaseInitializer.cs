using CoachPage.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoachPage.DataAccessLayer
{
    public class DataBaseInitializer : DropCreateDatabaseAlways<DataBaseContext>
    {
        protected override void Seed(DataBaseContext context)
        {
            SeedData(context);

            base.Seed(context);
        }

        private static void SeedData(DataBaseContext context)
        {
            var trainer = new Trainer { Name = "Karola", Surrname = "Brysz", Description = "Coś tam o mnie", PhotoFileName = "fot" };
            context.Trainers.Add(trainer);
            context.SaveChanges();

            var posts = new List<Post>{
                new Post{Text="lorem ipsum", PublicationDate=DateTime.Now, PhotoFileName="photo name"},
                new Post{Text="lorem ipsum", PublicationDate=DateTime.Now, PhotoFileName="photo name"},
                new Post{Text="lorem ipsum", PublicationDate=DateTime.Now, PhotoFileName="photo name"},
                new Post{Text="lorem ipsum", PublicationDate=DateTime.Now, PhotoFileName="photo name"},
                new Post{Text="lorem ipsum", PublicationDate=DateTime.Now, PhotoFileName="photo name"}
            };
            posts.ForEach(p => context.Posts.Add(p));
            context.SaveChanges();

            var proteges = new List<Protege>
            {
                new Protege{StudentName="Kasia", HorseName="Dante", Description="opis", PhotoFileName="photo name"},
                new Protege{StudentName="Aneta", HorseName="Damaszek", Description="opis", PhotoFileName="photo name"},
                new Protege{StudentName="Karol", HorseName="Bulka", Description="opis", PhotoFileName="photo name"}
            };
            proteges.ForEach(p => context.Proteges.Add(p));
            context.SaveChanges();
        }
    }
}