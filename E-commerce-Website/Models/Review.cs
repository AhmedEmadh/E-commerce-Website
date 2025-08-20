using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_Website.Models;

public partial class Review
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    public string? Subject { get; set; }

    public string? Description { get; set; }
}
