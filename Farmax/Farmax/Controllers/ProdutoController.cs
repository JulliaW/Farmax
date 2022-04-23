using Farmax.Context;
using Farmax.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Farmax.Controllers
{
    public class ProdutoController : Controller
    {
        private Contexto db = new Contexto();
        // GET: Produto
        public ActionResult Index()
        {
            var produto = db.Produto.ToList();
            return View(produto);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                db.Produto.Add(produto);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(produto);
        }

        [HttpGet]
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProdutoModel produto = db.Produto.Find(Id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            return PartialView(produto);
        }

        [HttpGet]
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProdutoModel produto = db.Produto.Find(Id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            return PartialView(produto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoModel produto)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(produto).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(produto);
                }
            }
            return View(produto);
        }

        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProdutoModel produto = db.Produto.Find(Id);

            if (produto == null)
            {
                return HttpNotFound();
            }

            return PartialView(produto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ProdutoModel produto)
        {
            db.Entry(produto).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}