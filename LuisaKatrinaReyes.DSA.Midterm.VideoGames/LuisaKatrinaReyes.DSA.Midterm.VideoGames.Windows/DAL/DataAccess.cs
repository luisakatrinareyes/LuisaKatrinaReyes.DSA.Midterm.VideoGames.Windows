using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;

namespace LuisaKatrinaReyes.DSA.Midterm.VideoGames.Windows.DAL
{
    class DataAccess : DbContext
    {
        public DataAccess() : base("myConnectionString")
        {

        }
    }
}
