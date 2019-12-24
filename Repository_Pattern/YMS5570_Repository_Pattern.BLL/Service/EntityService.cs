using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMS5570_Repository_Pattern.BLL.Repository;

namespace YMS5570_Repository_Pattern.BLL.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _categoryService = new CategoryRepository();
            _articleService = new ArticleRepository();
            _appUserService = new AppUserRepository();
            _commentService = new CommentRepository();
            _likeService = new LikeRepository();
        }

        private CategoryRepository _categoryService;

        public CategoryRepository CategoryService 
        {
            get { return _categoryService; }
            set { _categoryService = value; }
        }

        private ArticleRepository _articleService;
        public ArticleRepository ArticleService 
        {
            get { return _articleService; }
            set { _articleService = value; }
        }

        private AppUserRepository _appUserService;
        public AppUserRepository AppUserService
        {
            get { return _appUserService; }
            set { _appUserService = value; }
        }

        private CommentRepository _commentService;
        public CommentRepository CommentService
        {
            get { return _commentService; }
            set { _commentService = value; }
        }

        private LikeRepository _likeService;
        public LikeRepository LikeService
        {
            get { return _likeService; }
            set { _likeService = value; }
        }
    }
}
