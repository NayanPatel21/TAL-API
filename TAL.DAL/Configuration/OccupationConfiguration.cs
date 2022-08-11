using TAL.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAL.Common.Models;

namespace TAL.DAL.Configuration
{
    public class OccupationConfiguration : IEntityTypeConfiguration<Occupation>
    {
        public void Configure(EntityTypeBuilder<Occupation> builder)
        {
            builder.ToTable(Constants.TAL_DAL_Entity_Occupations);


            builder.HasData
            (
                new Occupation
                {
                    OccupationId = 1,
                    OccupationName = Constants.TAL_DAL_Entity_Occupations_Cleaner,
                    OccupationRatingRefId = 3
                },
                 new Occupation
                 {
                     OccupationId = 2,
                     OccupationName = Constants.TAL_DAL_Entity_Occupations_Doctor,
                     OccupationRatingRefId = 1
                 },
                new Occupation
                {
                    OccupationId = 3,
                    OccupationName = Constants.TAL_DAL_Entity_Occupations_Author,
                    OccupationRatingRefId = 2
                },
                 new Occupation
                 {
                     OccupationId = 4,
                     OccupationName = Constants.TAL_DAL_Entity_Occupations_Farmer,
                     OccupationRatingRefId = 4
                 },
                new Occupation
                {
                    OccupationId = 5,
                    OccupationName = Constants.TAL_DAL_Entity_Occupations_Mechanic,
                    OccupationRatingRefId = 4
                },
                new Occupation
                {
                    OccupationId = 6,
                    OccupationName = Constants.TAL_DAL_Entity_Occupations_Florist,
                    OccupationRatingRefId = 3
                }
            );
        }
    }
}
