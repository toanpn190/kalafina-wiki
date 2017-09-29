using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kalafina.Migrations;
using Kalafina.Models;

namespace Kalafina.Controllers
{
    public class SongsController : Controller
    {
        private MusicContext db = new MusicContext();

        // GET: Songs
        public async Task<ActionResult> Index()
        {
            var songs = db.Songs.Include(s => s.Album);
            return View(await songs.ToListAsync());
        }

        // GET: Songs/Create
        public ActionResult Create()
        {
            PopulateAlbumsDropDownList();
            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "TrackNo,AlbumID,Title")] Song song)
        {
            if (ModelState.IsValid)
            {
                db.Songs.Add(song);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            PopulateAlbumsDropDownList();
            return View(song);
        }

        // GET: Songs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Song song = await db.Songs.FindAsync(id);
            if (song == null)
            {
                return HttpNotFound();
            }

            PopulateAlbumsDropDownList();
            return View(song);
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,TrackNo,AlbumID,Title")] Song song)
        {
            if (ModelState.IsValid)
            {
                db.Entry(song).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            PopulateAlbumsDropDownList();
            return View(song);
        }

        // GET: Songs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Song song = await db.Songs.FindAsync(id);
            if (song == null)
            {
                return HttpNotFound();
            }
            return View(song);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Song song = await db.Songs.FindAsync(id);
            db.Songs.Remove(song);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


        private void PopulateAlbumsDropDownList()
        {
            var albums = from a in db.Albums
                                   orderby a.Title
                                   select a;
            ViewBag.AlbumID = new SelectList(albums, "ID", "Title");
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
