using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoWeb.Models;

namespace TodoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        static List<Usuario> lista = new List<Usuario>();
        // GET: Usuario
        public ActionResult Index()
        {
            lista.Add(new Usuario { UsuarioId = 1, Nome = "Fulano" });
            lista.Add(new Usuario { UsuarioId = 2, Nome = "Ciclano" });

            //ViewBag.Usuarios = lista;
            return View(lista);
        }

        //get:usuario/create
        public ActionResult Create()
        {
            return View();
        }
    }
}