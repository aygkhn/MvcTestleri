using System.Data.Entity.Migrations;

namespace NorthwindDemo.Models.DataAccess.Migrations
{
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);

            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        CategoryID = c.Int(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitsInStock = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);

            //Customer Rows
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Beverages', N'Soft drinks, coffees, teas, beers, and ales')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Condiments', N'Sweet and savory sauces, relishes, spreads, and seasonings')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Confections', N'Desserts, candies, and sweet breads')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Dairy Products', N'Cheeses')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Grains/Cereals', N'Breads, crackers, pasta, and cereal')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Meat/Poultry', N'Prepared meats')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Produce', N'Dried fruit and bean curd')");
            Sql("INSERT [dbo].[Categories] ([CategoryName], [Description]) VALUES (N'Seafood', N'Seaweed and fish')");

            //Product Rows
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Chai Tea Latte', 1, N'10 boxes x 20 bags', 18.0000, 39)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Chang', 1, N'24 - 12 oz bottles', 19.0000, 17)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Aniseed Syrup', 2, N'12 - 550 ml bottles', 10.0000, 13)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Chef Anton''s Cajun Seasoning', 2, N'48 - 6 oz jars', 22.0000, 53)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Chef Anton''s Gumbo Mix', 2, N'36 boxes', 21.3500, 0)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Grandma''s Boysenberry Spread', 2, N'12 - 8 oz jars', 25.0000, 120)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Uncle Bob''s Organic Dried Pears', 7, N'12 - 1 lb pkgs.', 30.0000, 15)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Northwoods Cranberry Sauce', 2, N'12 - 12 oz jars', 40.0000, 6)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Mishi Kobe Niku', 6, N'18 - 500 g pkgs.', 97.0000, 29)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Ikura', 8, N'12 - 200 ml jars', 31.0000, 31)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Queso Cabrales', 4, N'1 kg pkg.', 21.0000, 22)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Queso Manchego La Pastora', 4, N'10 - 500 g pkgs.', 38.0000, 86)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Konbu', 8, N'2 kg box', 6.0000, 24)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Tofu', 7, N'40 - 100 g pkgs.', 23.2500, 35)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Genen Shouyu', 2, N'24 - 250 ml bottles', 15.5000, 39)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Pavlova', 3, N'32 - 500 g boxes', 17.4500, 29)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Alice Mutton', 6, N'20 - 1 .', 62.5000, 42)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Teatime Chocolate Biscuits', 3, N'10 boxes x 12 pieces', 9.2000, 25)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Sir Rodney''s Marmalade', 3, N'30 gift boxes', 81.0000, 40)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Sir Rodney''s Scones', 3, N'24 pkgs. x 4 pieces', 10.0000, 3)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gustaf''s Knäckebröd', 5, N'24 - 500 g pkgs.', 21.0000, 104)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Tunnbröd', 5, N'12 - 250 g pkgs.', 9.0000, 61)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Guaraná Fantástica', 1, N'12 - 355 ml cans', 4.5000, 20)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'NuNuCa Nuß-Nougat-Creme', 3, N'20 - 450 g glasses', 14.0000, 76)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gumbär Gummibärchen', 3, N'100 - 250 g bags', 31.2300, 15)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Schoggi Schokolade', 3, N'100 - 100 g pieces', 43.9000, 49)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Rössle Sauerkraut', 7, N'25 - 825 g cans', 45.6000, 26)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Thüringer Rostbratwurst', 6, N'50 bags x 30 sausgs.', 123.7900, 0)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Nord-Ost Matjeshering', 8, N'10 - 200 g glasses', 25.8900, 10)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gorgonzola Telino', 4, N'12 - 100 g pkgs', 12.5000, 0)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Mascarpone Fabioli', 4, N'24 - 200 g pkgs.', 32.0000, 9)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Geitost', 4, N'500 g', 2.5000, 112)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Sasquatch Ale', 1, N'24 - 12 oz bottles', 14.0000, 111)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Steeleye Stout', 1, N'24 - 12 oz bottles', 18.0000, 20)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Inlagd Sill', 8, N'24 - 250 g  jars', 19.0000, 112)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gravad lax', 8, N'12 - 500 g pkgs.', 26.0000, 11)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Côte de Blaye', 1, N'12 - 75 cl bottles', 263.5000, 17)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Chartreuse verte', 1, N'750 cc per bottle', 18.0000, 69)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Boston Crab Meat', 8, N'24 - 4 oz tins', 18.4000, 123)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Jack''s New England Clam Chowder', 8, N'12 - 12 oz cans', 9.6500, 85)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Singaporean Hokkien Fried Mee', 5, N'32 - 1 kg pkgs.', 14.0000, 26)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Ipoh Coffee', 1, N'16 - 500 g tins', 46.0000, 17)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gula Malacca', 2, N'20 - 2 kg bags', 19.4500, 27)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Rogede sild', 8, N'1k pkg.', 9.5000, 5)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Spegesild', 8, N'4 - 450 g glasses', 12.0000, 95)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Zaanse koeken', 3, N'10 - 4 oz boxes', 9.5000, 36)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Chocolade', 3, N'10 pkgs.', 12.7500, 15)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Maxilaku', 3, N'24 - 50 g pkgs.', 20.0000, 10)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Valkoinen suklaa', 3, N'12 - 100 g bars', 16.2500, 65)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Manjimup Dried Apples', 7, N'50 - 300 g pkgs.', 53.0000, 20)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Filo Mix', 5, N'16 - 2 kg boxes', 7.0000, 38)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Perth Pasties', 6, N'48 pieces', 32.8000, 0)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Tourtière', 6, N'16 pies', 7.4500, 21)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Pâté chinois', 6, N'24 boxes x 2 pies', 24.0000, 115)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gnocchi di nonna Alice', 5, N'24 - 250 g pkgs.', 38.0000, 21)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Ravioli Angelo', 5, N'24 - 250 g pkgs.', 19.5000, 36)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Escargots de Bourgogne', 8, N'24 pieces', 13.2500, 62)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Raclette Courdavault', 4, N'5 kg pkg.', 55.0000, 79)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Camembert Pierrot', 4, N'15 - 300 g rounds', 34.0000, 19)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Sirop d''érable', 2, N'24 - 500 ml bottles', 28.5000, 113)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Tarte au sucre', 3, N'48 pies', 49.3000, 17)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Vegie-spread', 2, N'15 - 625 g jars', 43.9000, 24)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Wimmers gute Semmelknödel', 5, N'20 bags x 4 pieces', 33.2500, 22)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Louisiana Fiery Hot Pepper Sauce', 2, N'32 - 8 oz bottles', 21.0500, 76)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Louisiana Hot Spiced Okra', 2, N'24 - 8 oz jars', 17.0000, 4)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Laughing Lumberjack Lager', 1, N'24 - 12 oz bottles', 14.0000, 52)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Scottish Longbreads', 3, N'10 boxes x 8 pieces', 12.5000, 6)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Gudbrandsdalsost', 4, N'10 kg pkg.', 36.0000, 26)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Outback Lager', 1, N'24 - 355 ml bottles', 15.0000, 15)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Flotemysost', 4, N'10 - 500 g pkgs.', 21.5000, 26)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Mozzarella di Giovanni', 4, N'24 - 200 g pkgs.', 34.8000, 14)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Röd Kaviar', 8, N'24 - 150 g jars', 15.0000, 101)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Longlife Tofu', 7, N'5 kg pkg.', 10.0000, 4)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Rhönbräu Klosterbier', 1, N'24 - 0.5 l bottles', 7.7500, 125)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Lakkalikööri', 1, N'500 ml', 18.0000, 57)");
            Sql("INSERT [dbo].[Products] ([ProductName], [CategoryID], [QuantityPerUnit], [UnitPrice], [UnitsInStock]) VALUES (N'Original Frankfurter grüne Soße', 2, N'12 boxes', 13.0000, 32)");
        }

        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
