using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MKEWasteDisposal.Models;
using Microsoft.AspNet.Identity;

namespace MKEWasteDisposal.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers
        public ActionResult Index(string zipCode, string option)
        {
            if (!String.IsNullOrEmpty(zipCode))
            {
                return View(db.Customers.Include(c => c.Address).Where(x => x.Address.ZipCode.Equals(zipCode) && x.PickUpDate == option).ToList());
            }
            var customers = db.Customers.Include(c => c.Address).Include(c => c.Bill);
            return View(customers.ToList());
        }

        // GET: Customers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Customer customer = db.Customers
                                .Include(c => c.Address)
                                .Include(c => c.Bill)
                                .SingleOrDefault(x => x.CustomerID == id);
            
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressId", "StreetAddress");
            ViewBag.BillId = new SelectList(db.Bills, "BillId", "BillId");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,FirstName,LastName,PhoneNumber,PickUpDate,AddressID,BillId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.UserID = User.Identity.GetUserId();
                db.Customers.Add(customer);
                db.SaveChanges();
                TempData["Message"] = "Profile has been saved!";
                return RedirectToAction("Confirmation");
                //return RedirectToAction("Index");
 
            }

            ViewBag.AddressID = new SelectList(db.Addresses, "AddressId", "StreetAddress", customer.AddressID);
            ViewBag.BillId = new SelectList(db.Bills, "BillId", "BillId", customer.BillId);
            return View(customer);
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressId", "StreetAddress", customer.AddressID);
            ViewBag.BillId = new SelectList(db.Bills, "BillId", "BillId", customer.BillId);
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,FirstName,LastName,PhoneNumber,PickUpDate,AddressID,BillId")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AddressID = new SelectList(db.Addresses, "AddressId", "StreetAddress", customer.AddressID);
            ViewBag.BillId = new SelectList(db.Bills, "BillId", "BillId", customer.BillId);
            return View(customer);
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers
                               .Include(c => c.Address)
                               .Include(c => c.Bill)
                               .SingleOrDefault(x => x.CustomerID == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [Authorize(Roles = "Admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
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

        public ActionResult Confirmation()
        {
            return View();
        }
    }
}
