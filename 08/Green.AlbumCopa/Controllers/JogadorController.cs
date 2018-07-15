using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Green.AlbumCopa.Data;
using Green.AlbumCopa.Models;

namespace Green.AlbumCopa.Controllers
{
    public class JogadorController : Controller
    {
        private AppDbContext db = new AppDbContext();

        // GET: Jogador
        public async Task<ActionResult> Index()
        {
            return View(await db.Jogador.ToListAsync());
        }

        // GET: Jogador/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = await db.Jogador.FindAsync(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // GET: Jogador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jogador/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Nome,Pais,Numero,DataCriacao")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                db.Jogador.Add(jogador);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(jogador);
        }

        // GET: Jogador/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = await db.Jogador.FindAsync(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // POST: Jogador/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Nome,Pais,Numero,DataCriacao")] Jogador jogador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jogador).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(jogador);
        }

        // GET: Jogador/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jogador jogador = await db.Jogador.FindAsync(id);
            if (jogador == null)
            {
                return HttpNotFound();
            }
            return View(jogador);
        }

        // POST: Jogador/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Jogador jogador = await db.Jogador.FindAsync(id);
            db.Jogador.Remove(jogador);
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
