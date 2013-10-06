using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Framawork;

namespace Consultas.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult enviaDadosContato(FormCollection form)
        {
            string nome = form["txtNome"];
            string email = form["txtEmail"];
            string estado = form["slcEstado"];
            string mensagem = form["txtMsg"];
            Mail.enviaDadosContato(nome, email, mensagem);
            return RedirectToAction("Index");

        }

    }
}
