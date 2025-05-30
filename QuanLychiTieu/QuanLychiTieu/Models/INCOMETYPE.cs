namespace QuanLychiTieu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##THAI.INCOMETYPE")]
    public partial class INCOMETYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INCOMETYPE()
        {
            INCOMEs = new HashSet<INCOME>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal INTYPEID { get; set; }

        [StringLength(250)]
        public string NAMEINTYPE { get; set; }
        public decimal? USERID { get; set; }

        [StringLength(1)]
        public string ISACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCOME> INCOMEs { get; set; }
        public virtual USER USER { get; set; }
    }
}
