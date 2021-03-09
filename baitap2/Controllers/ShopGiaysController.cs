using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baitap2.Models;

namespace baitap2.Controllers
{
    public class ShopGiaysController : Controller
    {
        private DemoDbConText db = new DemoDbConText();

        // GET: ShopGiays
        public ActionResult Index()
        {
            return View(db.ShopGiays.ToList());
        }

        // GET: ShopGiays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopGiay shopGiay = db.ShopGiays.Find(id);
            if (shopGiay == null)
            {
                return HttpNotFound();
            }
            return View(shopGiay);
        }

        // GET: ShopGiays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopGiays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDKhachhang,Tenkhachhang,IDGiay,LoaiGiay")] ShopGiay shopGiay)
        {
            if (ModelState.IsValid)
            {
                db.ShopGiays.Add(shopGiay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopGiay);
        }

        // GET: ShopGiays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopGiay shopGiay = db.ShopGiays.Find(id);
            if (shopGiay == null)
            {
                return HttpNotFound();
            }
            return View(shopGiay);
        }

        // POST: ShopGiays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDKhachhang,Tenkhachhang,IDGiay,LoaiGiay")] ShopGiay shopGiay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopGiay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopGiay);
        }

        // GET: ShopGiays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopGiay shopGiay = db.ShopGiays.Find(id);
            if (shopGiay == null)
            {
                return HttpNotFound();
            }
            return View(shopGiay);
        }

        // POST: ShopGiays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ShopGiay shopGiay = db.ShopGiays.Find(id);
            db.ShopGiays.Remove(shopGiay);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
