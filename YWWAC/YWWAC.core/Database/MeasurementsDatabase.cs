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
    public class MeasurementsDatabase : IMeasurementsDatabase
    {
        private SQLiteConnection database;
        public MeasurementsDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Measurements>();
        }
        public async Task<IEnumerable<Measurements>> GetMeasurements()
        {
            return database.Table<Measurements>().ToList();
        }
        public async Task<int> DeleteMeasurements(object id)
        {
            return database.Delete<Measurements>(Convert.ToInt16(id));
        }
        public async Task<int> InsertMeasurements(Measurements measurements)
        {
            var num = database.Insert(measurements);
            database.Commit();
            return num;
        }
        public async Task<int> UpdateMeasurements(Measurements measurements)
        {
            return database.Update(measurements);
        }
        public async Task<bool> CheckIfExists(Measurements measurements)
        {
            var exists = database.Table<Measurements>().Any(
                x => x.Id == measurements.Id || x.DateTime.Date == measurements.DateTime.Date);
            return exists;
        }
    }
}
