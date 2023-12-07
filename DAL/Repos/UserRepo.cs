

using DAL.EF;
using DAL.EF.Models;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    public class UserRepo
    {
        public static string GetRepo(int id)
        {
            return id == 110 ? "Tanvir" : "Not found";
        }

        public static List<News> GetNews()
        {
            var db = new NewsContext();
            
            return db.Newses.ToList();
        }
        public static bool Add(News news)
        {
            var db = new NewsContext();
            db.Newses.Add(news);
            return db.SaveChanges()>0;
        }
        
    }
}
