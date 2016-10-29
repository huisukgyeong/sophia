using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.Interfaces
{
    public interface IGoalsDatabase
    {
        Task<IEnumerable<Goals>> GetGoals();
        Task<int> DeleteGoals(object id);
        Task<int> InsertGoals(Goals goals);
    }
}
