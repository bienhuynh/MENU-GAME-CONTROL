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
    public class GameServiceController : Controller
    {
        private SGPCloudEntities db = new SGPCloudEntities();

        // GET: List_Game_Disk
        public async Task<ActionResult> Index()
        {
            return View(await db.List_Game_Disk.ToListAsync());
        }

        // GET: List_Game_Disk/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List_Game_Disk list_Game_Disk = await db.List_Game_Disk.FindAsync(id);
            if (list_Game_Disk == null)
            {
                return HttpNotFound();
            }
            return View(list_Game_Disk);
        }

        // GET: List_Game_Disk/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: List_Game_Disk/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,NameGame,URL,IconUrL,IconBinary,DateScan,Size,Description,Version")] List_Game_Disk list_Game_Disk)
        {
            if (ModelState.IsValid)
            {
                db.List_Game_Disk.Add(list_Game_Disk);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(list_Game_Disk);
        }

        // GET: List_Game_Disk/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List_Game_Disk list_Game_Disk = await db.List_Game_Disk.FindAsync(id);
            if (list_Game_Disk == null)
            {
                return HttpNotFound();
            }
            return View(list_Game_Disk);
        }

        // POST: List_Game_Disk/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,NameGame,URL,IconUrL,IconBinary,DateScan,Size,Description,Version")] List_Game_Disk list_Game_Disk)
        {
            if (ModelState.IsValid)
            {
                db.Entry(list_Game_Disk).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(list_Game_Disk);
        }

        // GET: List_Game_Disk/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List_Game_Disk list_Game_Disk = await db.List_Game_Disk.FindAsync(id);
            if (list_Game_Disk == null)
            {
                return HttpNotFound();
            }
            return View(list_Game_Disk);
        }

        // POST: List_Game_Disk/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            List_Game_Disk list_Game_Disk = await db.List_Game_Disk.FindAsync(id);
            db.List_Game_Disk.Remove(list_Game_Disk);
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
