using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Columns;

[ColumnsScript("ECommerceWebsite.OrderDetails")]
[BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
public class OrderDetailsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string UserName { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public string OrderName { get; set; }
    public decimal Price { get; set; }
}