namespace ITI901_ProyectoTutorial_Aguinaga.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ITI901_ProyectoTutorial_Aguinaga.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ITI901_ProyectoTutorial_Aguinaga.Models.ApplicationDbContext";
        }

        protected override void Seed(ITI901_ProyectoTutorial_Aguinaga.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
