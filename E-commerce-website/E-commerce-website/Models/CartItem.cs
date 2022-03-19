﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Models
{
    public partial class CartItem
    {
        [Key]
        public int id { get; set; }
        [Key]
        public int UserID { get; set; }
        public int? ProductID { get; set; }
        public int? Quantity { get; set; }

        [ForeignKey(nameof(ProductID))]
        [InverseProperty("CartItems")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(UserID))]
        [InverseProperty("CartItems")]
        public virtual User User { get; set; }
    }
}