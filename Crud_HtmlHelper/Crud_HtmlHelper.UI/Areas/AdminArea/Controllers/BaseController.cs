using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud_HtmlHelper.DAL.ORM.Context;

namespace Crud_HtmlHelper.UI.Areas.AdminArea.Controllers
{
    public class BaseController : Controller
    {
        public ProjectContext db;

        public BaseController()
        {
            db = new ProjectContext();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
    }
}