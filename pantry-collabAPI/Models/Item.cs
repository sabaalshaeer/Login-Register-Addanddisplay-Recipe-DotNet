using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace pantry_collabAPI.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [StringLength(500)]
        public string? Url { get; set; }
        public int? Weight { get; set; }
        public double Calories { get; set; }
        public int Quantity { get; set; }
        public bool? Avaibility { get; set; }



    }
}
