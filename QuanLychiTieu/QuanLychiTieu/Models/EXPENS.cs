namespace QuanLychiTieu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##THAI.EXPENSES")]
    public partial class EXPENS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal EXPENSESID { get; set; }

        public decimal? USERID { get; set; }

        public decimal? EXTYPEID { get; set; }

        public decimal? MONEY { get; set; }

        public DateTime? EXDATE { get; set; }

        [StringLength(250)]
        public string NOTE { get; set; }

        public virtual USER USER { get; set; }

        public virtual EXPENSESTYPE EXPENSESTYPE { get; set; }
    }
}
