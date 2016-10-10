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
    public class ConsultantsDatabase : IConsultantsDatabase
    {
        private SQLiteConnection database;
        public ConsultantsDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Consultant>();
        }
        public async Task<IEnumerable<Consultant>> GetConsultants()
        {
            return database.Table<Consultant>().ToList();
        }
        public async Task<int> DeleteConsultant(object id)
        {
            return database.Delete<Consultant>(Convert.ToInt16(id));
        }
        public async Task<int> InsertConsultant(Consultant consultant)
        {
            var num = database.Insert(consultant);
            database.Commit();
            return num;
        }
    }
}
