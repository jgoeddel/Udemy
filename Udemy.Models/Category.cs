using System.ComponentModel.DataAnnotations;

namespace Udemy.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } // Automaticly Primary Key
        [Required]
        public string Name { get; set; }
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "Value must between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
