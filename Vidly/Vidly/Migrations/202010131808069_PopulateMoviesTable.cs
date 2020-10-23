namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (1, 'Hangover', '2009-06-05', '2009-12-05', 6, 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (2, 'Die Hard', '1988-07-20'," +
               " '1989-01-20', 3, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (3, 'The terminator', '1984-10-26'," +
              " '1985-04-26', 10, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (4, 'Toy Story', '1995-11-22'," +
             " '1986-05-22', 1, 3)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES (5, 'Titanic', '1997-12-19'," +
           " '1998-06-19', 9, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
