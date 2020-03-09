using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DotNetSaleCore.ConsoleApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        [JsonIgnore] // Microsoft Docs + JsonIgnore
        public virtual Category Category { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
