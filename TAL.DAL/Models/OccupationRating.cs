using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TAL.Common.Models;

namespace TAL.DAL.Models
{
    public class OccupationRating
    {
        [Key]
        public int OccupationRatingId { get; set; }

        [Column(TypeName = Constants.TAL_DAL_Model_nvarchar)]
        public string OccupationRatingName { get; set; }

        [Column(TypeName = Constants.TAL_DAL_Model_Decimal)]
        public decimal Factor { get; set; }
    }
}
