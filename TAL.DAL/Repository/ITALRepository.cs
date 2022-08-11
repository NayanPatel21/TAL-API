using System.Collections.Generic;
using TAL.DAL.Models;

namespace TAL.DAL.Repository
{
    public interface ITALRepository
    {
        IEnumerable<Occupation> GetAllOccupation();
    }
}
