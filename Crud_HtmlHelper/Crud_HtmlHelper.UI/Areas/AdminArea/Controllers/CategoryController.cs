using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud_HtmlHelper.MODEL.Entity;
using Crud_HtmlHelper.UI.Areas.AdminArea.Models;
using Crud_HtmlHelper.UI.Areas.AdminArea.Models.Messages;

namespace Crud_HtmlHelper.UI.Areas.AdminArea.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: AdminArea/Category
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(CategoryDTO model)
        {
            if (ModelState.IsValid)
            {
                Category cat = new Category();
                cat.CategoryName = model.CategoryName;
                cat.Description = model.Description;
                db.Categories.Add(cat);
                db.SaveChanges(); 
                ViewBag.ProcessCondition = 1;
                return View();

            }
            else
            {
                ViewBag.ProcessCondition = 2;
                return View();
            }
           
        }

        public ActionResult List()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Edit(int? ID)
        {
            Category category = db.Categories.Find(ID);
            CategoryDTO model = new  CategoryDTO();
            model.ID = category.ID;
            model.CategoryName = category.CategoryName;
            model.Description = category.Description;
            return View(model);

        }

        [HttpPost]
        public ActionResult Edit(CategoryDTO category)
        {
         
            if (ModelState.IsValid)
            {
                Category data = db.Categories.Find(category.ID);
                data.CategoryName = category.CategoryName;
                data.Description = category.Description;
                db.Entry(data).State = EntityState.Modified; ;
                db.SaveChanges();
                ViewBag.ProcessCondition = 1;
                return RedirectToAction("List");

            }
            else
            {
                ViewBag.ProcessCondition = 2;
                return View(category);
            }

        }

        public ActionResult Delete(int? ID)
        {

            Category category = db.Categories.FirstOrDefault(x => x.ID == ID);
            ID = category.ID;
            db.Entry(category).State = EntityState.Deleted;
            category.status = BaseEntity.Status.Passive;
            //req.BU = value.BU;
            try
            {
                ViewBag.ProcessCondition = 1;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                ViewBag.ProcessCondition = 2;
                throw ex;
            }
            return RedirectToAction("List");
        }
    }
}