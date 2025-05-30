namespace QuanLychiTieu.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("C##THAI.INCOME")]
    public partial class INCOME
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal INCOMEID { get; set; }

        public decimal? USERID { get; set; }

        public decimal? INTYPEID { get; set; }

        public decimal? MONEY { get; set; }

        public DateTime? INDATE { get; set; }

        [StringLength(250)]
        public string NOTE { get; set; }

        public virtual USER USER { get; set; }

        public virtual INCOMETYPE INCOMETYPE { get; set; }
    }
}
