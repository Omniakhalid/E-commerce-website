// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Models
{
    [Table("Vendor")]
    public partial class Vendor
    {
        public Vendor()
        {
            Products = new HashSet<Product>();
            VendorRegisterDate = DateTime.Now;
        }

        [Key]
        public int VendorID { get; set; }
        [Required]
        [StringLength(100)]
        public string VendorName { get; set; }
        [Required]
        [StringLength(200)]
        public string VendorAddress { get; set; }
        [Required]
        [StringLength(50)]
        public string VendorPhone { get; set; }
        [Required]
        [StringLength(50)]
        public string VendorCity { get; set; }
        [Required]
        [StringLength(100)]
        public string VendorEmail { get; set; }
        [Required]
        [StringLength(100)]
        public string VendorPassword { get; set; }
        [StringLength(100)]
        public string VendorVerficationCode { get; set; }
        [Required]
        [StringLength(100)]
        public string VendorCountry { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime VendorRegisterDate { get; set; }

        [InverseProperty(nameof(Product.Vendor))]
        public virtual ICollection<Product> Products { get; set; }
    }
}