namespace QuanLychiTieu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##THAI.USERS")]
    public partial class USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USER()
        {
            EXPENSES = new HashSet<EXPENS>();
            INCOMEs = new HashSet<INCOME>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal USERID { get; set; }

        [StringLength(100)]
        public string FULLNAME { get; set; }

        [StringLength(10)]
        public string GENDER { get; set; }

        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(250)]
        public string PASSWORD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EXPENS> EXPENSES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INCOME> INCOMEs { get; set; }
    }
}
