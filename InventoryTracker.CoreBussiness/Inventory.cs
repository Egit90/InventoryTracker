using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.CoreBussiness
{
    public class Inventory
    {
        public int InventoryID { get; set; }
        [Required]
        [StringLength(100)]
        public string InventoryName { get; set; } =string.Empty;
        [Range(1, int.MaxValue , ErrorMessage ="Qty Must Be greater than 0")]
        public int Quantity { get; set; }

        [Range(1, int.MaxValue , ErrorMessage ="Price Must Be greater than 0")]
        public double Price { get; set; }
    }
}