using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgendaTupBrande.Models.Dtos
{
    public class ContactDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CelularNumber { get; set; }
        public string Email { get; set; }
        public Boolean Favorite { get; set; }

        //[ForeignKey("UserId")]
        //public int UserId { get; set; }
        
    }
}
