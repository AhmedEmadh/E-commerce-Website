using Serenity.ComponentModel;
using System;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.Products")]
[BasedOnRow(typeof(ProductsRow), CheckNames = true)]
public class ProductsForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public string Photo { get; set; }
    public DateTime DateAdded { get; set; }
    public int Quantity { get; set; }
}