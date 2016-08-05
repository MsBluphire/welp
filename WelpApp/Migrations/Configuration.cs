namespace WelpApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WelpApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WelpApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WelpApp.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.BusinessTypes.AddOrUpdate(p => p.BusinessTypeID,

                new BusinessType

                {
                    BusinessTypeID = 1,
                    BusinessTypeName ="Restaurant",
                    
                },

                new BusinessType
                {
                    BusinessTypeID = 2, 
                    BusinessTypeName = "Barbershop",
                },

                new BusinessType
                {
                    BusinessTypeID = 3, 
                    BusinessTypeName = "Bar",
                },

                new BusinessType
                {
                    BusinessTypeID = 4, 
                    BusinessTypeName = "Hotel",
                }

                );


            context.Businesses.AddOrUpdate(p => p.BusinessName,

                new Business
                {
                    BusinessName = "Pineappleants",
                    BusinessTypeID = 1,
                    Address = "1001 Euclid Ave, Cleveland, OH",
                    Hours = "4pm - 10pm",
                    Phone = "216 - 543 - 9876",
                    Menu = "image of menu, link to their menu or website",

                },

                new Business
                {
                    BusinessName = "Cutz",
                    BusinessTypeID = 2, 
                    Address = "2345 Rodeo Drive, Los Angeles, CA",
                    Hours = "9am - 9pm",
                    Phone = "198-749-6051",
                    Menu = "Image of services/price menu, link to their menu or website",


                },

                new Business
                {
                    BusinessName = "Drunks",
                    BusinessTypeID = 3, 
                    Address = "666 AA Lane, Penitentiary, OH",
                    Hours = "4pm - 2am",
                    Phone = "614-LUV-BEER",
                    Menu = "JUST DRINKS",

                },

                new Business
                {
                    BusinessName = "Scandal Inn",
                    BusinessTypeID = 4, 
                    Address = "9172 Desperate Lane, Promiscuous, PA",
                    Hours = "24 hours",
                    Phone = "202-NOT-MINE",
                    Menu = "Listing of room packages, prices and availability",

                }

                );

                
    

                

        }
    }
}
