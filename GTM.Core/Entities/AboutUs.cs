using System.ComponentModel.DataAnnotations;

namespace GTM.Core.Entities
{
    public class AboutUs
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
