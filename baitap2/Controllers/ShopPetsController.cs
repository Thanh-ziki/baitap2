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
    public class ShopPetsController : Controller
    {
        private DemoDbConText db = new DemoDbConText();

        // GET: ShopPets
        public ActionResult Index()
        {
            return View(db.ShopPets.ToList());
        }

        // GET: ShopPets/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopPet shopPet = db.ShopPets.Find(id);
            if (shopPet == null)
            {
                return HttpNotFound();
            }
            return View(shopPet);
        }

        // GET: ShopPets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopPets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPet,TenPet,LoaiPet,TuoiCuaPet")] ShopPet shopPet)
        {
            if (ModelState.IsValid)
            {
                db.ShopPets.Add(shopPet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopPet);
        }

        // GET: ShopPets/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopPet shopPet = db.ShopPets.Find(id);
            if (shopPet == null)
            {
                return HttpNotFound();
            }
            return View(shopPet);
        }

        // POST: ShopPets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPet,TenPet,LoaiPet,TuoiCuaPet")] ShopPet shopPet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopPet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopPet);
        }

        // GET: ShopPets/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopPet shopPet = db.ShopPets.Find(id);
            if (shopPet == null)
            {
                return HttpNotFound();
            }
            return View(shopPet);
        }

        // POST: ShopPets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ShopPet shopPet = db.ShopPets.Find(id);
            db.ShopPets.Remove(shopPet);
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
