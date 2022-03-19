﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_commerce_website.Models
{
    public partial class OptionGroup
    {
        public OptionGroup()
        {
            Options = new HashSet<Option>();
        }

        [Key]
        public int OptionGroupID { get; set; }
        [StringLength(50)]
        
        public string OptionGroupName { get; set; }

        [InverseProperty(nameof(Option.OptionGroup))]
        public virtual ICollection<Option> Options { get; set; }
    }
}