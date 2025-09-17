using Serenity.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.OrderDetails")]
[BasedOnRow(typeof(OrderDetailsRow), CheckNames = true)]
public class OrderDetailsForm
{
    public string UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int OrderId { get; set; }
    public decimal Price { get; set; }
}