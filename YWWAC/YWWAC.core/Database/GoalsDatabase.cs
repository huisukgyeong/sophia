using MvvmCross.Platform;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Interfaces;
using YWWAC.core.Models;

namespace YWWAC.core.Database
{
    public class GoalsDatabase : IGoalsDatabase
    {
        private SQLiteConnection database;
        public GoalsDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Goals>();
        }
        public async Task<IEnumerable<Goals>> GetGoals()
        {
            return database.Table<Goals>().ToList();
        }
        public async Task<int> DeleteGoals(object id)
        {
            return database.Delete<Goals>(Convert.ToInt16(id));
        }
        public async Task<int> InsertGoals(Goals goals)
        {
            var num = database.Insert(goals);
            database.Commit();
            return num;
        }
    }
}
