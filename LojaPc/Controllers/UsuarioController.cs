using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LojaPc.Models;
using System.Web.Security;

namespace LojaPc.Controllers
{
    public class UsuarioController : Controller
    {
        private Context db = new Context();

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Validacao.SetSessionId(0);
            return RedirectToAction("Login", "Usuario");
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuario usuario, bool permanecerLogado)
        {
            Usuario u = db.Usuarios.FirstOrDefault(x => x.UsuarioNome.Equals(usuario.UsuarioNome) && x.UsuarioSenha.Equals(usuario.UsuarioSenha));
            if (u != null)
            {
                FormsAuthentication.SetAuthCookie(u.UsuarioNome, permanecerLogado);
                Validacao.SetSessionId(u.UsuarioId);
                return RedirectToAction("Index", "Empresa");
            }
            else
            {
                ModelState.AddModelError("", "Usuario ou senha invalidos!");
            }
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UsuarioId,UsuarioNome,UsuarioEmail,UsuarioSenha,UsuarioConfirmaSenha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Role = "Usuario";
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UsuarioId,UsuarioNome,UsuarioEmail,UsuarioSenha,UsuarioConfirmaSenha")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuarios.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuarios.Find(id);
            db.Usuarios.Remove(usuario);
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
