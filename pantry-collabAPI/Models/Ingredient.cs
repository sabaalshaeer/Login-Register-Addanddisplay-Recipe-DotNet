using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace pantry_collabAPI.Models
{
    public class Ingredient
    {
     
      
            public int Id { get; set; }
            public string Name { get; set; }
            public int? Weight { get; set; }
        [StringLength(500)]
        public string? Url { get; set; }
        public double Calories { get; set; }
            
            //Navegation Property 
            

            
           

        
    }
}
