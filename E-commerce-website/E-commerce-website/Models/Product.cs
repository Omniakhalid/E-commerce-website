// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Models
{
    [Index(nameof(ProductCategoryID), Name = "IX_Products_ProductCategoryID")]
    [Index(nameof(VendorID), Name = "IX_Products_VendorID")]
    public partial class Product
    {
        public Product()
        {
            CartItems = new HashSet<CartItem>();
            CartItemsOptions = new HashSet<CartItemsOption>();
            OrderDetails = new HashSet<OrderDetail>();
            OrderItemsOptions = new HashSet<OrderItemsOption>();
            ProductOptions = new HashSet<ProductOption>();
        }

        [Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductName { get; set; }
        [Column(TypeName = "money")]
        public decimal ProductPrice { get; set; }
        public double? ProductWeight { get; set; }
        [Required]
        [StringLength(250)]
        public string ProductShortDes { get; set; }
        [StringLength(3000)]
        public string ProductLongDes { get; set; }
        [Required]
        [StringLength(200)]
        public string ProductImage { get; set; }
        public int ProductCategoryID { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProductUpdateDate { get; set; }
        public int ProductStock { get; set; }
        public int VendorID { get; set; }

        [ForeignKey(nameof(ProductCategoryID))]
        [InverseProperty("Products")]
        public virtual ProductCategory ProductCategory { get; set; }
        [ForeignKey(nameof(VendorID))]
        [InverseProperty("Products")]
        public virtual Vendor Vendor { get; set; }
        [InverseProperty(nameof(CartItem.Product))]
        public virtual ICollection<CartItem> CartItems { get; set; }
        [InverseProperty(nameof(CartItemsOption.Product))]
        public virtual ICollection<CartItemsOption> CartItemsOptions { get; set; }
        [InverseProperty(nameof(OrderDetail.Product))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [InverseProperty(nameof(OrderItemsOption.Product))]
        public virtual ICollection<OrderItemsOption> OrderItemsOptions { get; set; }
        [InverseProperty(nameof(ProductOption.Product))]
        public virtual ICollection<ProductOption> ProductOptions { get; set; }
    }
}