using DAL.EF.Models;
using DAL.Interface;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<News, int, bool> NewsData()
        {
            return new UserRepo();
        }

        public static IRepo<News,int,bool> StudentData()
        {
            return null;
        }
    }
}
