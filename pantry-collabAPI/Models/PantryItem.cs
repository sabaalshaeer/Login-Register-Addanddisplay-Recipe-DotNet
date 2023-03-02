using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static System.Net.WebRequestMethods;

namespace pantry_collabAPI.Models
{
    public class PantryItem
    {
        public int Id{ get; set; }
        public string ItemName { get; set; } 
        [StringLength(500)]
        public string? Url { get; set; }
        public bool? Avaibility { get; set; }

        public double Calories { get; set; }
      
        public double Weight { get; set; }
        public int quantity { get; set; }
        // Navigation Property
        public int UserId { get; set; }
      
        




    }
}
