namespace Notepad.Migrations
{
    using Notepad.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.UI.WebControls;

    internal sealed class Configuration : DbMigrationsConfiguration<Notepad.Models.RecordContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Notepad.Models.RecordContext context)
        {
            var notes = new List<Note>
            {
            new Note{Topic="aaa", Content="bbb", Category="bbbb", Author="bbbb", Date="bbb", Working=1},
            };
            var categories = new List<Category>
            {
            new Category{Name="aaa"},
            };
            notes.ForEach(s => context.Notes.Add(s));
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
        }
    }
}
