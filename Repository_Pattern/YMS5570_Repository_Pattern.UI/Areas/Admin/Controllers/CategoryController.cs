﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YMS5570_Repository_Pattern.DAL.ORM.Entity.Concrete;
using YMS5570_Repository_Pattern.UI.Areas.Admin.Models.DTO;

namespace YMS5570_Repository_Pattern.UI.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category data)
        {
            service.CategoryService.Add(data);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult List()
        {
            List<Category> model = service.CategoryService.GetActive();
            return View(model);
        }

        public ActionResult Update(Guid id)
        {
            Category cat = service.CategoryService.GetById(id);
            CategoryDTO model = new CategoryDTO();
            model.ID = cat.ID;
            model.Name = cat.Name;
            model.Description = cat.Description;
            return View(model);

        }

        [HttpPost]
        public ActionResult Update(CategoryDTO data)
        {
            Category cat = service.CategoryService.GetById(data.ID);
            cat.Name = data.Name;
            cat.Description = data.Description;
            service.CategoryService.Update(cat);
            return Redirect("/Admin/Category/List");
        }

        public ActionResult Delete(Guid id)
        {
            service.CategoryService.Remove(id);
            return Redirect("/Admin/Category/List");
        }
    }
}