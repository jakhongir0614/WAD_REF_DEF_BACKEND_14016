using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WAD_REFDEF_BACKEND_14016.Models
{
    public class Key
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name of the key is required!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Price of the key is required!")]
        public double Price { get; set; }
        [Required(ErrorMessage = "User of the key is required!")]

        public int? UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
