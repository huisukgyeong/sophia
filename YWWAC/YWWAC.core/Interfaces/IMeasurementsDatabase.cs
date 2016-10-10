using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.Interfaces
{
    public interface IMeasurementsDatabase
    {
        Task<IEnumerable<Measurements>> GetMeasurements();
        Task<int> DeleteMeasurements(object id);
        Task<int> InsertMeasurements(Measurements measurements);
        Task<int> UpdateMeasurements(Measurements measurements);
        Task<bool> CheckIfExists(Measurements measurements);
    }
}
