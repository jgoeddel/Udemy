using System.ComponentModel.DataAnnotations;

namespace Udemy.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; } // Automaticly Primary Key
        [Required]
        public string Name { get; set; }
    }
}
