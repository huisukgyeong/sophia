using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.Interfaces
{
    public interface IExercisesDatabase
    {
        Task<IEnumerable<Exercise>> GetExercises();
        Task<int> DeleteExercise(object id);
        Task<int> InsertExercise(Exercise exercise);
    }
}
