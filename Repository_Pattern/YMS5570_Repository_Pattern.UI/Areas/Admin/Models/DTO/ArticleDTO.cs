using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;
using YMS5570_Repository_Pattern.UI.Areas.Admin.Models.VM;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Models.DTO
{
    public class ArticleDTO:BaseDTO
    {

        public string Header { get; set; }
        public string Content { get; set; }
        public  Guid CategoryID { get; set; }
        public  Guid AppUserID { get; set; }
       


    }
}