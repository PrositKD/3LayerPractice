

using DAL.EF;
using DAL.EF.Models;
using DAL.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<News, int, bool>
    {
        public bool Add(News obj)
        {
           db.Newses.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Delete(int id)
        {
            var ex = Get(id);
            db.Newses.Remove(ex);
            return db.SaveChanges()>0;
        }

        public List<News> Get()
        {
           return db.Newses.ToList();
        }

        public News Get(int id)
        {
            return db.Newses.Find(id);
        }

        public bool update(News obj)
        {
            var ex = Get(obj.Id);
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges()>0;

        }
    }
}
