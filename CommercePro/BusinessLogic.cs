using SQLite;

namespace CommercePro
{
    [Table("Product")]
    public class Product
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("productid")]
        public int ProductID { get; set; }
        [Column("name")]
        public string? ProductName { get; set; }

        [Column("catid")]
        public string? CategoryID { get; set; }
        [Column("unitprice")]
        public string? UnitPrice { get; set; }
        [Column("quantity")]
        public string? QuantityInStock { get; set; }
    }

    [Table("categories")]
    public class Categories
    {
        [PrimaryKey]
        [AutoIncrement]
        [Column("catid")]
        public int CategoryID { get; set; }
        [Column("catName")]
        public string? CategoryName { get; set; }
    }

}
