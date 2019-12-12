using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_HtmlHelper.UI.Areas.AdminArea.Models
{
    public class CategoryDTO:BaseDTO
    {
        [Required(ErrorMessage = "Add category name")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Add category description")]
        public string Description { get; set; }
    }
}