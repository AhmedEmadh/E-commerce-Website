using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Columns;

[ColumnsScript("ECommerceWebsite.Categories")]
[BasedOnRow(typeof(CategoriesRow), CheckNames = true)]
public class CategoriesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
}