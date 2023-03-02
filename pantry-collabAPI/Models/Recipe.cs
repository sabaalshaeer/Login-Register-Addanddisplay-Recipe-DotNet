using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace pantry_collabAPI.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(500)]
        public string? Url { get; set; }
        public int UserId { get; set; }

        public List<Ingredient>? Ingredients { get; set;}
        public List<Step>? Steps { get; set; }


        //Recipe is the dependent entity
    }
}
