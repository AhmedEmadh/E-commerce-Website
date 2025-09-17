using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website.Models;

[Table("Order")]
public partial class Order
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string UserId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateAdded { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalPrice { get; set; }

    public int? Status { get; set; }

    [NotMapped]
    public OrderStatus StatusEnum
    {
        get { return (OrderStatus)(Status ?? 0); }
        set { Status = (int)value; }
    }

    [InverseProperty("Order")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
