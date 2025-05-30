namespace QuanLychiTieu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##THAI.EXPENSESTYPE")]
    public partial class EXPENSESTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EXPENSESTYPE()
        {
            EXPENSES = new HashSet<EXPENS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EXTYPEID { get; set; }

        [StringLength(250)]
        public string NAMEEXTYPE { get; set; }
        public decimal? USERID { get; set; }

        [StringLength(1)]
        public string ISACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPENS> EXPENSES { get; set; }
        public virtual USER USER { get; set; }
    }
}
