using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TAL.DAL.Models;

namespace TAL.DAL.Repository
{
    public class TALRepository : ITALRepository
    {
        private TALDBContext context;
        public TALRepository(TALDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Occupation> GetAllOccupation()
        {
            return this.context.Occupations
                    .Include(a => a.OccupationRating).ToList();
        }

    }
}
