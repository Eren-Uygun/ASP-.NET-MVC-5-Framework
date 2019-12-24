using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;
using YMS5570_Repository_Pattern.UI.Areas.Admin.Models.DTO;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Models.VM
{
    public class UpdateArticleVM : BaseVM
    {
        public UpdateArticleVM()
        {

            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
            Article = new ArticleDTO();
        }

        public List<AppUser> AppUsers { get; set; }
        public List<Category> Categories { get; set; }

        public  ArticleDTO Article { get; set; }
    
    }
}