using Serenity.ComponentModel;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Columns;

[ColumnsScript("ECommerceWebsite.Reviews")]
[BasedOnRow(typeof(ReviewsRow), CheckNames = true)]
public class ReviewsColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
}