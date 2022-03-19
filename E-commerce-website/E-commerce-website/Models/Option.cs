﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Models
{
    public partial class Option
    {
        public Option()
        {
            ProductOptions = new HashSet<ProductOption>();
        }

        [Key]
        public int OptionID { get; set; }
        [Required]
        [StringLength(50)]
        
        public string OptionName { get; set; }
        public int OptionGroupID { get; set; }

        [ForeignKey(nameof(OptionGroupID))]
        [InverseProperty("Options")]
        public virtual OptionGroup OptionGroup { get; set; }
        [InverseProperty(nameof(ProductOption.Option))]
        public virtual ICollection<ProductOption> ProductOptions { get; set; }
    }
}