using Serenity.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.Categories")]
[BasedOnRow(typeof(CategoriesRow), CheckNames = true)]
public class CategoriesForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
}