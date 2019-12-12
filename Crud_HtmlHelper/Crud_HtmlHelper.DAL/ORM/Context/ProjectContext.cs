using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud_HtmlHelper.MODEL.Entity;

namespace Crud_HtmlHelper.DAL.ORM.Context
{
   public class ProjectContext:DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=CrudHelper;UID=Sa;PWD=123;";
        }

        public DbSet<Category> Categories { get; set; }
    }

}
