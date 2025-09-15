using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Columns;

[ColumnsScript("ECommerceWebsite.Products")]
[BasedOnRow(typeof(ProductsRow), CheckNames = true)]
public class ProductsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string CategoryName { get; set; }
    public string Photo { get; set; }
    public DateTime DateAdded { get; set; }
    public int Quantity { get; set; }
}