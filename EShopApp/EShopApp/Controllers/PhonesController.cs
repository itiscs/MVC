﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EShopApp.Models;

namespace EShopApp.Controllers
{
    public class PhonesController : Controller
    {
        private EShopDB db = new EShopDB();

        // GET: Phones
        public ActionResult Index()
        {
            return View(db.Phones.ToList());
        }

        // GET: Phones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phone phone = db.Phones.Find(id);
            if (phone == null)
            {
                return HttpNotFound();
            }
            return View(phone);
        }

        // GET: Phones/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Phones/Create
        //// Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        //// сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "ID,Brand,Model,Price,ImageFile,Amount")] Phone phone)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Phones.Add(phone);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(phone);
        //}

        //// GET: Phones/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Phone phone = db.Phones.Find(id);
        //    if (phone == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phone);
        //}

        //// POST: Phones/Edit/5
        //// Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        //// сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Brand,Model,Price,ImageFile,Amount")] Phone phone)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(phone).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(phone);
        //}

        //// GET: Phones/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Phone phone = db.Phones.Find(id);
        //    if (phone == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(phone);
        //}

        //// POST: Phones/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Phone phone = db.Phones.Find(id);
        //    db.Phones.Remove(phone);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
