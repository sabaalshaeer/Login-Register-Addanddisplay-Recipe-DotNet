using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace pantry_collabAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "User Fullname is required")]
        public string FullName { get; set; } = string.Empty;
        [Required(ErrorMessage = "User UserName is required")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "User Password is required")]
        public string Password { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "User Email is required")]
        public string Email { get; set; } = string.Empty;
        public string FamilyMember { get; set; } = string.Empty;
        //? assign to be  optional
        //Navagation Properties
      
        public List<Recipe>? Recipes { get; set; }
        public List<PantryItem>? PantryItems { get; set; }

        //User is the principal entity
    }
}
