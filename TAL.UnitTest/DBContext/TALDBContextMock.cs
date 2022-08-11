using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TAL.Common.Models;
using TAL.DAL.Models;

namespace TAL.UnitTest.DBContext
{
    public class TALDBContextMock
    {

        public TALDBContext MockDBContext()
        {
            var options = new DbContextOptionsBuilder<TALDBContext>()
     .UseInMemoryDatabase(databaseName: Constants.TAL_Test_Context_TALDB)
     .Options;
            var context = new TALDBContext(options);

            #region Occupation


            context.Occupations.Add(new Occupation
            {
                OccupationId = 1,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Cleaner,
                OccupationRatingRefId = 3
            });
            context.Occupations.Add(new Occupation
            {
                OccupationId = 2,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Doctor,
                OccupationRatingRefId = 1
            });

            context.Occupations.Add(new Occupation
            {
                OccupationId = 3,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Author,
                OccupationRatingRefId = 2
            });

            context.Occupations.Add(new Occupation
            {
                OccupationId = 4,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Farmer,
                OccupationRatingRefId = 4
            });

            context.Occupations.Add(new Occupation
            {
                OccupationId = 5,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Mechanic,
                OccupationRatingRefId = 4
            });

            context.Occupations.Add(new Occupation
            {
                OccupationId = 6,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Florist,
                OccupationRatingRefId = 3
            });
            #endregion

            #region OccupationRatingConfiguration
            context.OccupationRatings.Add(new OccupationRating
            {
                OccupationRatingId = 1,
                OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Professional,
                Factor = 1.0M
            });

            context.OccupationRatings.Add(new OccupationRating
            {
                OccupationRatingId = 2,
                OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_White_Collar,
                Factor = 1.25M
            });

            context.OccupationRatings.Add(new OccupationRating
            {
                OccupationRatingId = 3,
                OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Light_Manual,
                Factor = 1.50M
            });

            context.OccupationRatings.Add(new OccupationRating
            {
                OccupationRatingId = 4,
                OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Heavy_Manual,
                Factor = 1.75M
            });
            #endregion

            context.SaveChanges();

            return context;
        }
    }
}

