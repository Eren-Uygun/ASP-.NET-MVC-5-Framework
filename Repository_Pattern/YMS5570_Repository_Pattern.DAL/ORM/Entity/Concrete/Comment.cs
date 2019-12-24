using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete
{
    public class Comment:BaseEntity
    {
        public string Content { get; set; }

        public Guid ArticleID { get; set; }
        public virtual Article Article { get; set; }

        public Guid AppUserID { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
