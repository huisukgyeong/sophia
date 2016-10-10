using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YWWAC.core.Models;

namespace YWWAC.core.Interfaces
{
    public interface IConsultantsDatabase
    {
        Task<IEnumerable<Consultant>> GetConsultants();
        Task<int> DeleteConsultant(object id);
        Task<int> InsertConsultant(Consultant consultant);
    }
}
