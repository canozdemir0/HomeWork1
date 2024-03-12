using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Models.ORM
{
    public class Products : BaseModel
    {
        [Key]
        public int ProductsID { get; set; }

        [MaxLength(40)]
        public string ProductName { get; set; }

        public int? SupplierID { get; set; }
        [ForeignKey("SupplierID")]
        public Supplier Suppliers { get; set; }

        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Categories { get; set; }

        [MaxLength(20)]
        public string? QuantityPerUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "smallint")]
        public int? UnitsInStock { get; set; }

        [Column(TypeName = "smallint")]
        public int? UnitsOnOrder { get; set; }

        [Column(TypeName = "smallint")]
        public int? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

    }
}
