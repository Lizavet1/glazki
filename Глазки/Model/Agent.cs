namespace Глазки.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Agent")]
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            ProductSale = new HashSet<ProductSale>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public int AgentTypeID { get; set; }

        [StringLength(300)]
        public string Address { get; set; }

        [Required]
        [StringLength(12)]
        public string INN { get; set; }

        [StringLength(9)]
        public string KPP { get; set; }

        [StringLength(100)]
        public string DirectorName { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Logo { get; set; }

        public int Priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSale { get; set; }
    }
}
