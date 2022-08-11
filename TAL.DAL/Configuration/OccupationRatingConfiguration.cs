using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAL.Common.Models;
using TAL.DAL.Models;

namespace TAL.DAL.Configuration
{
    public class OccupationRatingConfiguration : IEntityTypeConfiguration<OccupationRating>
    {
        public void Configure(EntityTypeBuilder<OccupationRating> builder)
        {
            builder.ToTable(Constants.TAL_DAL_Entity_OccupationRating);


            builder.HasData
            (
                new OccupationRating
                {
                    OccupationRatingId = 1,
                    OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Professional,
                    Factor = 1.0M
                },
                  new OccupationRating
                  {
                      OccupationRatingId = 2,
                      OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_White_Collar,
                      Factor = 1.25M
                  },
                    new OccupationRating
                    {
                        OccupationRatingId = 3,
                        OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Light_Manual,
                        Factor = 1.50M
                    },
                      new OccupationRating
                      {
                          OccupationRatingId = 4,
                          OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Heavy_Manual,
                          Factor = 1.75M
                      }
            );
        }
    }
}
