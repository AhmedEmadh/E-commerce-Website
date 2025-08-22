using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website.Models;

public partial class ProductImage
{
    [Key]
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Image { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("ProductImages")]
    public virtual Product? Product { get; set; }
}
