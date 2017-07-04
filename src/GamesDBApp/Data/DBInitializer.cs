using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GamesDBApp.Data;

namespace GamesDBApp.Models
{
    public static class DbInitializer
    {
        public static void Initialize(GamesContext context)
        {
            context.Database.EnsureCreated();

            // Check for any existing games
            if (context.Games.Any())
            {
                return;   // DB has been seeded
            }

            // Define test data to initialize database with
            var games = new Game[]
            {
            new Game{Title="Shadow of the Colossus", Genre="Action-Adventure", Developer="Team ICO", ReleaseDate = DateTime.Parse("2005-10-18")},
            new Game{Title="Fallout New Vegas", Genre="RPG", Developer="Obsidian Entertainment", ReleaseDate = DateTime.Parse("2010-10-19")},
            new Game{Title="Overwatch", Genre="FPS", Developer="Blizzard Entertainment", ReleaseDate = DateTime.Parse("2016-5-24")}
            };
            foreach (Game g in games)
            {
                context.Games.Add(g);
            }
            context.SaveChanges();

        }
    }
}