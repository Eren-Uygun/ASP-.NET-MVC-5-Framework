using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Models.DTO
{
    public class CategoryDTO:BaseDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}