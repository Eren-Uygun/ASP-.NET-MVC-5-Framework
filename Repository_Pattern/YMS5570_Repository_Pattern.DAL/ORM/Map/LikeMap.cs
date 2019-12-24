using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;

namespace YMS5570_Repository_Pattern.DAL.ORM.Map
{
    public class LikeMap:CoreMap<Like>
    {
        public LikeMap()
        {
            ToTable("dbo.Likes");

            HasKey(x => new
            {
                x.ArticleID,
                x.AppUserID
            });
        }
    }
}
