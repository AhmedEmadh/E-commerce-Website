using Serenity.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.Reviews")]
[BasedOnRow(typeof(ReviewsRow), CheckNames = true)]
public class ReviewsForm
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
}