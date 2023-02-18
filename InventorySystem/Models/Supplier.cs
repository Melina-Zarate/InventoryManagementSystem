namespace InventorySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplier()
        {
            Product = new HashSet<Product>();
        }

        public int ID { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(50, ErrorMessage = "Supplier name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Supplier address is required.")]
        [StringLength(100, ErrorMessage = "Supplier addrees cannot be longer than 100 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Supplier phone is required.")]
        [StringLength(25, ErrorMessage = "Supplier phone cannot be longer than 25 characters.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Supplier email is required.")]
        [StringLength(50, ErrorMessage = "Supplier email cannot be longer than 50 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Supplier contact person is required.")]
        [StringLength(50, ErrorMessage = "Supplier contact person cannot be longer than 50 characters.")]
        public string ContactPerson { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
