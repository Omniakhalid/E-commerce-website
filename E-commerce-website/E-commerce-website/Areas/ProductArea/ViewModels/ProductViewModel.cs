using E_commerce_website.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Areas.ProductArea.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            CartItems = new HashSet<CartItem>();
            OrderDetails = new HashSet<OrderDetail>();
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
        public IFormFile ProductImageFile { get; set; }
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
        [InverseProperty(nameof(OrderDetail.Product))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [InverseProperty(nameof(ProductOption.Product))]
        public virtual ICollection<ProductOption> ProductOptions { get; set; }
    }
}
