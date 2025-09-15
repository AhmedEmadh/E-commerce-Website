using Serenity.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.Carts")]
[BasedOnRow(typeof(CartsRow), CheckNames = true)]
public class CartsForm
{
    public string UserId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}