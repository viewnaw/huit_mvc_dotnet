using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HUIT_ASPMVC.Controllers
{
    public class VaiTroController : BaseController
    {
        // GET: VaiTro
        public ActionResult Index()
        {
            var models = unitOfWork.VaiTroRepo.GetAll();
            return View(models);
        }

        // GET: VaiTro/Details/5
        public ActionResult Details(int id)
        {
            var models = unitOfWork.VaiTroRepo.Find(id);
            return View(models);
        }

        // GET: VaiTro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VaiTro/Create
        [HttpPost]
        public ActionResult Create(VaiTro model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = unitOfWork.VaiTroRepo.Insert(model);
                    if (result.IDVaiTro > 0)
                    {
                        return RedirectToAction("Index", "VaiTro");
                    }
                    // làm gì đó
                }
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VaiTro/Edit/5
        public ActionResult Edit(int id)
        {
            VaiTro model = unitOfWork.VaiTroRepo.Find(id);
            return View(model);
        }

        // POST: VaiTro/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, VaiTro model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.VaiTroRepo.Update(model);
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: VaiTro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VaiTro/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
