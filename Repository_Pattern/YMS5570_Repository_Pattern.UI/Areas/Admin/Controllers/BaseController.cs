using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5570_Repository_Pattern.BLL.Service;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        protected EntityService service;

        public BaseController()
        {
            service = new EntityService();
        }
    }
}