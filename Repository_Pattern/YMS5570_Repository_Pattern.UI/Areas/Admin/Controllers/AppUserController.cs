using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;
using YMS5570_Repository_Pattern.UI.Areas.Admin.Models.DTO;
using Role = YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete.Role;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Controllers
{
    public class AppUserController : BaseController
    {
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser data)
        {
            service.AppUserService.Add(data);
            return Redirect("/Admin/AppUser/List");
        }

        public ActionResult List()
        {
            List<AppUser> model = service.AppUserService.GetActive();
            return View(model);
        }

        public ActionResult Delete(Guid id)
        {
            service.AppUserService.Remove(id);
            return Redirect("/Admin/AppUser/List");
        }

        public ActionResult Update(Guid id)
        {
            AppUser user = service.AppUserService.GetById(id);
            AppUserDTO userDto = new AppUserDTO();
            userDto.ID = user.ID;
            userDto.FirstName = user.FirstName;
            userDto.LastName = user.LastName;
            userDto.UserName = user.UserName;
            userDto.Email = user.Email;
            userDto.Password = userDto.Password;
            userDto.Role = user.Role;
            return View(userDto);

        }
        [HttpPost]
        public ActionResult Update(AppUserDTO data)
        {
            AppUser user = service.AppUserService.GetById(data.ID);
            user.FirstName = data.FirstName;
            user.LastName = data.LastName;
            user.UserName = data.UserName;
            user.Email = data.Email;
            user.Password = data.Password;
            user.Role = data.Role;
            service.AppUserService.Update(user);
            return Redirect("/Admin/AppUser/List");

        }
    }
}