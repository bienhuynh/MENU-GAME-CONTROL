using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SGP.HCBBOOK.CORE.Database;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    public class User_Game_OwnerController : Controller
    {
        private SGPCloudEntities db = new SGPCloudEntities();

        // GET: User_Game_Owner
        public async Task<ActionResult> Index()
        {
            var user_Game_Owner = db.User_Game_Owner.Include(u => u.List_Game_Disk).Include(u => u.UserProfile);
            return View(await user_Game_Owner.ToListAsync());
        }

        // GET: User_Game_Owner/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Game_Owner user_Game_Owner = await db.User_Game_Owner.FindAsync(id);
            if (user_Game_Owner == null)
            {
                return HttpNotFound();
            }
            return View(user_Game_Owner);
        }

        // GET: User_Game_Owner/Create
        public ActionResult Create()
        {
            ViewBag.GameId = new SelectList(db.List_Game_Disk, "Id", "NameGame");
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "FirstName");
            return View();
        }

        // POST: User_Game_Owner/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserId,GameId,IsShowOnMenu,IsRemoveOnDisk")] User_Game_Owner user_Game_Owner)
        {
            if (ModelState.IsValid)
            {
                db.User_Game_Owner.Add(user_Game_Owner);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.GameId = new SelectList(db.List_Game_Disk, "Id", "NameGame", user_Game_Owner.GameId);
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "FirstName", user_Game_Owner.UserId);
            return View(user_Game_Owner);
        }

        // GET: User_Game_Owner/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Game_Owner user_Game_Owner = await db.User_Game_Owner.FindAsync(id);
            if (user_Game_Owner == null)
            {
                return HttpNotFound();
            }
            ViewBag.GameId = new SelectList(db.List_Game_Disk, "Id", "NameGame", user_Game_Owner.GameId);
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "FirstName", user_Game_Owner.UserId);
            return View(user_Game_Owner);
        }

        // POST: User_Game_Owner/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserId,GameId,IsShowOnMenu,IsRemoveOnDisk")] User_Game_Owner user_Game_Owner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_Game_Owner).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.GameId = new SelectList(db.List_Game_Disk, "Id", "NameGame", user_Game_Owner.GameId);
            ViewBag.UserId = new SelectList(db.UserProfile, "UserId", "FirstName", user_Game_Owner.UserId);
            return View(user_Game_Owner);
        }

        // GET: User_Game_Owner/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Game_Owner user_Game_Owner = await db.User_Game_Owner.FindAsync(id);
            if (user_Game_Owner == null)
            {
                return HttpNotFound();
            }
            return View(user_Game_Owner);
        }

        // POST: User_Game_Owner/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            User_Game_Owner user_Game_Owner = await db.User_Game_Owner.FindAsync(id);
            db.User_Game_Owner.Remove(user_Game_Owner);
            await db.SaveChangesAsync();
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
