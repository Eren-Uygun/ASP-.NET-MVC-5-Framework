using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Models.VM
{
    public class AddArticleVM:BaseVM
    {
        public AddArticleVM()
        {
            AppUsers = new List<AppUser>();
            Categories = new List<Category>();
        }

      

        public List<AppUser> AppUsers { get; set; }
        public List<Category> Categories { get; set; }
    }
}