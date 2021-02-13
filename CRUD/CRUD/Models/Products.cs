using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Category { get; set; }
        [StringLength(20)]
        public string Color { get; set; }
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; }
        [Range(1, 100)]
        public int AvailableQuantity { get; set; }
    }
}
