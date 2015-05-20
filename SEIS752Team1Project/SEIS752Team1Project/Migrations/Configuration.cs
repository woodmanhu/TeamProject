namespace SEIS752Team1Project.Migrations
{
    using SEIS752Team1Project.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SEIS752Team1Project.Models.SEIS752Team1ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SEIS752Team1Project.Models.SEIS752Team1ProjectContext context)
        {
              //This method will be called after migrating to the latest version.

              //You can use the DbSet<T>.AddOrUpdate() helper extension method 
              //to avoid creating duplicate seed data. E.g.

            context.Events.AddOrUpdate(
              p => p.Id,
              new Event { Id = 1, Name="Baseball", Type="Sport", Date=new DateTime(2014,2,27),Location="Seattle", Url="http://thumb9.shutterstock.com/display_pic_with_logo/172243/112652516/stock-photo-sport-poster-baseball-player-background-with-space-112652516.jpg" },
              new Event { Id = 2, Name="FootBall", Type="Sport", Date=new DateTime(2013,4,1),Location="NationWide", Url="http://www.thewizofodds.com/.a/6a00e553e551d188340192ac60e20d970d-500wi" },
              new Event { Id = 3, Name = "Jerf Race Car Design", Type = "Sport", Date = new DateTime(2015, 4, 1), Location = "NationWide", Url = "http://cdn.jdrf.org/wp-content/uploads/2015/03/FY15_RaceCarDesignContest_400x200_gm_v1.jpg" },
              new Event { Id = 4, Name = "Football Championship", Type = "Sport", Date = new DateTime(2015, 4, 1), Location = "England", Url = "https://vecree.com/wp-content/uploads/2015/02/14959501-420x420.jpg" },
              new Event { Id = 5, Name = "Bicycle Race", Type = "Sport", Date = new DateTime(2015, 2, 1), Location = "Chicago", Url = "http://image.shutterstock.com/display_pic_with_logo/468556/468556,1266776085,5/stock-vector-vector-sport-poster-47162317.jpg" },
              new Event { Id = 6, Name="MegaFight Boxing",Type="Sport",Date=new DateTime(2015,5,2),Location="MGM,LasVegas",Url="http://24boxing.com.ua/uploads/images/boxers/16m0sxh.jpg"},
              new Event { Id = 7,Name="Anything Goes",Type="Musical",Date=new DateTime(2007,5,9),Location="UK",Url="https://s-media-cache-ak0.pinimg.com/736x/66/c9/39/66c93916dd03478a532df0623606e950.jpg" },
              new Event { Id = 8, Name = "Gigi", Type = "Musical", Date = new DateTime(2015, 4, 1), Location = "NationWide", Url = "http://theaterpimp.com/wp-content/uploads/2014/04/TPTSD_Gigi_400x400.jpg" },
              new Event { Id = 9, Name = "The Phantom Of The Opera", Type = "Musical", Date = new DateTime(2015, 4, 1), Location = "London", Url = "http://upload.wikimedia.org/wikipedia/en/f/f2/The_Phantom_of_the_Opera_at_the_Royal_Albert_Hall_Poster.jpg" },
              new Event { Id = 10, Name = "AeroSmith", Type = "Musical", Date = new DateTime(2015, 7, 19), Location = "MacDonald Island Park", Url = "http://www.rock979.ca/files/11018302_10152760240626317_303637497906601069_n-400x200.jpg" },
              new Event { Id = 11, Name = "Beauty And The Beast", Type = "Musical", Date = new DateTime(2015, 2, 24), Location = "Muangthai Rachadalai Theatre, Bangkok", Url = "http://www.thaiticketmajor.com/performance/images/beauty-and-the-beast-2014/poster.jpg" },
              new Event { Id = 12, Name = "Cats", Type = "Muscial", Date = new DateTime(2015, 1, 9), Location = "UK", Url = "http://enveeus.com/wp-content/uploads/2014/12/CATS-Poster.jpg" },
              new Event { Id = 13, Name = "Fast and Furious7", Type = "Movie", Date = new DateTime(2015, 4, 5), Location = "NationWide", Url = "http://cps-static.rovicorp.com/2/Open/NBC_Universal_30/Program/21947717/_derived_jpg_q90_410x410_m0/furious7poster.jpg?partner=allrovi.com" },
              new Event { Id = 14, Name = "Star Wars Episode VII", Type = "Movie", Date = new DateTime(2015, 7, 1), Location = "USA", Url = "http://media-cache-ak0.pinimg.com/236x/1c/b6/cb/1cb6cbadc975f2381f86b4f96ea6cdb5.jpg" },
              new Event { Id = 15, Name = "Avengers", Type = "Movie", Date = new DateTime(2015, 5, 1), Location = "IMAX Theaters", Url = "http://static1.squarespace.com/static/54298190e4b0027ed7da9fa3/t/54ecb156e4b056f5cc4ba1ed/1424798142432/Avengers-Age-of-Ultron-Poster-700x1037.jpg" },
              new Event { Id = 16, Name = "Terminator", Type = "Movie", Date = new DateTime(2015, 4, 1), Location = "Movie theaters", Url = "http://omgamazingpics.com/wp-content/uploads/2014/12/Terminator-Genisys-Poster.jpg" },
              new Event { Id = 17,Name = "Jurassic World", Type = "Movie", Date = new DateTime(2015, 7, 12), Location = "Movie Theaters", Url = "http://ia.media-imdb.com/images/M/MV5BMjMyNjI3ODQyNV5BMl5BanBnXkFtZTgwNDM5NTk5MjE@._V1_SX214_AL_.jpg" },
              new Event { Id = 18, Name = "Golf US Open", Type = "Sport", Date = new DateTime(2015, 7, 1), Location = "Chambers Bay,Washington", Url = "http://americasstandrews.com/wordpress/wp-content/uploads/2014/09/Poster-Designed-to-be-a-Champion.png" },
              new Event { Id = 19, Name = "Ted 2", Type = "Movie", Date = new DateTime(2015, 6, 26), Location = "Movie Theaters", Url = "http://1.bp.blogspot.com/-EZbBWBAnfyI/U9jmEULaScI/AAAAAAAAAEQ/0VjVUenf4XI/s1600/Ted+2+Movie.jpg" },
              new Event { Id = 20, Name = "Shrek", Type = "Musical", Date = new DateTime(2015, 5, 20), Location = "Anoka Children's Theatre,Minnesota", Url = "http://www.anoka.k12.mn.us/cms/lib08/MN01909485/Centricity/Domain/6975/Screen%20Shot%202015-01-08%20at%203.24.34%20PM.png" },
              new Event { Id = 21, Name = "College FootBall Championship", Type = "Sport", Date = new DateTime(2015, 1, 12), Location = "Ohio", Url = "http://ecx.images-amazon.com/images/I/51LJBLYB9CL._SX466_.jpg" },
              new Event { Id = 22, Name = "Joseph and The Amazing Tech-Dreamcoat", Type = "Musical", Date = new DateTime(2015, 7, 19), Location = "Buell Theaters, Denver", Url = "http://events.artsmemphis.org/sites/events.artsmemphis.org/images/event/441782339/joseph_poster_category.jpg" },
              new Event { Id = 23, Name = "Minions", Type = "Movie", Date = new DateTime(2015, 7, 10), Location = "Movie Theaters", Url = "http://3.bp.blogspot.com/-sI_K8if00mM/VJarKTmP8XI/AAAAAAAAADM/97d4OCp8jbQ/s1600/Minions%2BFilm.jpg" },
               new Event { Id = 24, Name = "Chappie", Type = "Movie", Date = new DateTime(2015, 7, 10), Location = "Movie Theaters", Url = "http://1.bp.blogspot.com/-V5qRoaYezMo/VPvk7juQ1iI/AAAAAAAAaTU/-R60EFKS2vI/s1600/CHAPPIE-movie-poster.jpg" }
              );
            
        }
    }
}
