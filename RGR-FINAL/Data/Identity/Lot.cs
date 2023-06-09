using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RGR_FINAL.Data.Identity
{
    [Table("Lots", Schema = "data")]
    public class Lot
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        [Display(Name = "Start of Trading")]
        [DataType(DataType.Time)]
        public DateTime StartDate { get; set; }
                
        [Display(Name = "End of Trading")]
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        [Display(Name = "Start Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal StartPrice { get; set; }
        public Categories? Category { get; set; }
        public bool Expired { get; set; }
       
    }
}
