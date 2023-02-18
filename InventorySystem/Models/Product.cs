namespace InventorySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        public int CategoryID { get; set; }

        public int SupplierID { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(75, ErrorMessage = "Product name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product description is required.")]
        [StringLength(100, ErrorMessage = "Product description cannot be longere tha 100 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Product price is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Product price must be a positive number.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Product cost is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Product cost must be a positive number.")]
        public int Cost { get; set; }

        [Required(ErrorMessage = "Product quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Product quantity must be a positive number.")]
        public int Quantity { get; set; }

        [Display(Name = "Category")]
        public virtual Category Category { get; set; }

        [Display(Name = "Supplier")]
        public virtual Supplier Supplier { get; set; }
    }
}
