using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Columns;

[ColumnsScript("ECommerceWebsite.Carts")]
[BasedOnRow(typeof(CartsRow), CheckNames = true)]
public class CartsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string UserId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
}