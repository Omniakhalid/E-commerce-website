using E_commerce_website.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce_website.Areas.ProductArea.ViewModels
{
    [Index(nameof(OptionGroupID), Name = "IX_Options_OptionGroupID")]
    public partial class OptionViewModel
    {
        public OptionViewModel()
        {
            ProductOptions = new HashSet<ProductOption>();
        }

        [Key]
        public int OptionID { get; set; }
        [Required]
        [StringLength(50)]
        public string OptionName { get; set; }

        ////////////////stopppppppp here///////////////////////
        public int ProductID { get; set; }
        public int id { get; set; }
        /////////////////////////////////////////////////////

        public int OptionGroupID { get; set; }

        [ForeignKey(nameof(OptionGroupID))]
        [InverseProperty("Options")]
        public virtual OptionGroup OptionGroup { get; set; }
        [InverseProperty(nameof(ProductOption.Option))]
        public virtual ICollection<ProductOption> ProductOptions { get; set; }
    }
}
