using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Work.APSOO.Dominio;
using Work.APSOO.RegraNegocio;

namespace Work.APSOO.UI.Controllers
{
    public class CursoController : Controller
    {
        private readonly CursoRN cursoRN;

        public CursoController()
        {
                cursoRN = new CursoRN();
        }

        // GET: Curso
        public ActionResult Index()
        {
            return View(cursoRN.ListarTodos());
        }

        // GET: Curso/Details/5
        public ActionResult Details(int id)
        {
            var curso = cursoRN.ListarTodos().Where(x => x.Id == id).FirstOrDefault();
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        [HttpPost]
        public ActionResult Create(Curso curso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var retorno = cursoRN.Criar(curso);
                    if (retorno == "")
                        RedirectToAction("index");
                    else
                        return View(curso);
                }
                else
                {
                    return View(curso);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View("index");
            }
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int id)
        {
            var aluno = cursoRN.ListarTodos().Where(x => x.Id == id).FirstOrDefault();
            return View(aluno);
        }

        // POST: Curso/Edit/5
        [HttpPost]
        public ActionResult Edit(Curso curso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var retorno = cursoRN.Alterar(curso);
                    if (retorno == "")
                        RedirectToAction("index");
                    else
                        return View(curso);
                }
                else
                {
                    return View(curso);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View("index");
            }
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int id)
        {
            var curso = cursoRN.ListarTodos().Where(x => x.Id == id).FirstOrDefault();
            return View(curso);
        }

        // POST: Curso/Delete/5
        [HttpPost]
        public ActionResult Delete(Curso curso)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var obj = cursoRN.ListarTodos().Where(x => x.Id == curso.Id).FirstOrDefault();
                    var retorno = cursoRN.Deletar(obj);
                    if (retorno == "")
                        RedirectToAction("index");
                    else
                        return View(curso);
                }
                else
                {
                    return View(curso);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View("index");
            }
        }
    }
}
