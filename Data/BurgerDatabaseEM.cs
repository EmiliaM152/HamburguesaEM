using HamburguesaEM.Models;
using HamburguesaEM.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburguesaEM.Data
{
    public class BurgerDatabaseEM
    {
        string _dbPath;
        private SQLiteConnection conn;
        //private List<BurgerEM> burgers;
        public BurgerDatabaseEM(string DatabasePath)
        {
            _dbPath = DatabasePath;
            //burgers = new List<BurgerEM>();
        }

        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerEM>();
        }
        public int AddNewBurger(BurgerEM burger)
        {
            if (burger.Id != 0)
                return conn.Update(burger);
            else
                return conn.Insert(burger);
        }

        public int DeleteBurger(BurgerEM burger)
        {
            Init();
            return conn.Delete(burger);
        }
        public List<BurgerEM> GetAllBurgers()
        {
            Init();
            List<BurgerEM> burgers = conn.Table<BurgerEM>().ToList();
            return burgers;
        }

    }
}
