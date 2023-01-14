using HamburguesaEM.Models;
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
        public BurgerDatabaseEM(string DatabasePath)
        {
            _dbPath = DatabasePath;
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
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<BurgerEM> GetAllBurgers()
        {
            Init();
            List<BurgerEM> burgers = conn.Table<BurgerEM>().ToList();
            return burgers;
        }
    }
}
