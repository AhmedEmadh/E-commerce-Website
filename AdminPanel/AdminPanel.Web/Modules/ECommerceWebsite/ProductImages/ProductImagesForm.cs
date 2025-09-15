using Serenity.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.ProductImages")]
[BasedOnRow(typeof(ProductImagesRow), CheckNames = true)]
public class ProductImagesForm
{
    public int ProductId { get; set; }
    public string Image { get; set; }
}