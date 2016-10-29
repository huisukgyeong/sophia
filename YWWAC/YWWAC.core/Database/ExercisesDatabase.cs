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
    public class ExercisesDatabase : IExercisesDatabase
    {
        private SQLiteConnection database;
        public ExercisesDatabase()
        {
            var sqlite = Mvx.Resolve<ISqlite>();
            database = sqlite.GetConnection();
            database.CreateTable<Exercise>();
        }
        public async Task<IEnumerable<Exercise>> GetExercises()
        {
            return database.Table<Exercise>().ToList();
        }
        public async Task<int> DeleteExercise(object id)
        {
            return database.Delete<Exercise>(Convert.ToInt16(id));
        }
        public async Task<int> InsertExercise(Exercise exercise)
        {
            var num = database.Insert(exercise);
            database.Commit();
            return num;
        }
    }
}
