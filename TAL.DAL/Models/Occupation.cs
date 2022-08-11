using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAL.Common.Models;

namespace TAL.DAL.Models
{
    public class Occupation
    {
        [Key]
        public int OccupationId { get; set; }

        [Column(TypeName = Constants.TAL_DAL_Model_nvarchar)]
        public string OccupationName { get; set; }

        public int OccupationRatingRefId { get; set; }

        [ForeignKey(Constants.TAL_DAL_Model_OccupationRatingRefId)]
        public OccupationRating OccupationRating { get; set; }

    }
}
