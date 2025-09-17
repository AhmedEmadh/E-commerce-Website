using Serenity.ComponentModel;
using System;

namespace AdminPanel.ECommerceWebsite.Forms;

[FormScript("ECommerceWebsite.Order")]
[BasedOnRow(typeof(OrderRow), CheckNames = true)]
public class OrderForm
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string UserId { get; set; }
    public DateTime DateAdded { get; set; }
    public decimal TotalPrice { get; set; }
    public int Status { get; set; }
}