using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SGP.HCBBOOK.CORE.Database;

namespace SGP.HCBBOOK.CloudServer.UI.Controllers
{
    public class List_Game_DiskController : ApiController
    {
        private SGPCloudEntities db = new SGPCloudEntities();

        // GET: api/List_Game_Disk
        public IQueryable<List_Game_Disk> GetList_Game_Disk()
        {
            return db.List_Game_Disk;
        }

        // GET: api/List_Game_Disk/5
        [ResponseType(typeof(List_Game_Disk))]
        public async Task<IHttpActionResult> GetList_Game_Disk(string id)
        {
            List_Game_Disk list_Game_Disk = await db.List_Game_Disk.FindAsync(id);
            if (list_Game_Disk == null)
            {
                return NotFound();
            }

            return Ok(list_Game_Disk);
        }

        // PUT: api/List_Game_Disk/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutList_Game_Disk(string id, List_Game_Disk list_Game_Disk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != list_Game_Disk.Id)
            {
                return BadRequest();
            }

            db.Entry(list_Game_Disk).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!List_Game_DiskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/List_Game_Disk
        [ResponseType(typeof(List_Game_Disk))]
        public async Task<IHttpActionResult> PostList_Game_Disk(List_Game_Disk list_Game_Disk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.List_Game_Disk.Add(list_Game_Disk);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (List_Game_DiskExists(list_Game_Disk.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = list_Game_Disk.Id }, list_Game_Disk);
        }

        // DELETE: api/List_Game_Disk/5
        [ResponseType(typeof(List_Game_Disk))]
        public async Task<IHttpActionResult> DeleteList_Game_Disk(string id)
        {
            List_Game_Disk list_Game_Disk = await db.List_Game_Disk.FindAsync(id);
            if (list_Game_Disk == null)
            {
                return NotFound();
            }

            db.List_Game_Disk.Remove(list_Game_Disk);
            await db.SaveChangesAsync();

            return Ok(list_Game_Disk);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool List_Game_DiskExists(string id)
        {
            return db.List_Game_Disk.Count(e => e.Id == id) > 0;
        }
    }
}