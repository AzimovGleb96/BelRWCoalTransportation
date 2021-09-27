namespace WebDolomit.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.PrimaryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebDolomit.DAL.PrimaryContext context)
        {
           // var countries = new List<Country>
           //{
           //    new Country { Name="БЧ"},
           //    new Country { Name="УЗ"},
           //    new Country { Name= "РФ,ЛГ"}
           //};

           // countries.ForEach(s => context.Countries.AddOrUpdate(p => p.Name, s));
           // context.SaveChanges();

           // var typeswagons = new List<TypeWagon>
           // {
           //     new TypeWagon { Type="ПВ"},
           //     new TypeWagon { Type="ХП"},
           //     new TypeWagon { Type="ХП(эксп)"},
           //     new TypeWagon { Type="ЦС ЦМВ"}
           // };

           // typeswagons.ForEach(s => context.TypeWagons.AddOrUpdate(p => p.Type, s));
           // context.SaveChanges();
        }
    }
}
   