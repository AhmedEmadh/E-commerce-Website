using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite.Columns;

[ColumnsScript("ECommerceWebsite.Order")]
[BasedOnRow(typeof(OrderRow), CheckNames = true)]
public class OrderColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string UserId { get; set; }
    public DateTime DateAdded { get; set; }
    public decimal TotalPrice { get; set; }
    public int Status { get; set; }
}