using System;
using System.Linq;
using System.Web.Mvc;
using Work.APSOO.Dominio;
using Work.APSOO.RegraNegocio;


namespace Work.APSOO.UI.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoRN alunoRN;
        
        public AlunoController()
        {
            alunoRN = new AlunoRN();
        }
        // GET: Aluno
        public ActionResult Index()
        {
            return View(alunoRN.ListarTodos());
        }

        // GET: Aluno/Details/5
        public ActionResult Details(Int64 id)
        {
            var aluno = alunoRN.ListarTodos().Where(x => x.Id == id).FirstOrDefault();
            return View(aluno);
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        public ActionResult Create(Aluno aluno)
        {
            try
            {
                if (ModelState.IsValid)
                {
               
                    var retorno =  alunoRN.Criar(aluno);
                    if (retorno == "")
                        RedirectToAction("index");    
                    else
                        return View(aluno);
                }
                else
                {
                    return View(aluno);
                }
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View("index");
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(Int64 id)
        {
            var aluno = alunoRN.ListarTodos().Where(x => x.Id == id).FirstOrDefault();
            return View(aluno);
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        public ActionResult Edit(Aluno aluno)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var retorno = alunoRN.Alterar(aluno);
                    if (retorno == "")
                        RedirectToAction("index");
                    else
                        return View(aluno);
                }
                else
                {
                    return View(aluno);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View("index");
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(Int64 id)
        {
            var aluno = alunoRN.ListarTodos().Where(x => x.Id == id).FirstOrDefault();
            return View(aluno);
        }

        // POST: Aluno/Delete/5
        [HttpPost]
        public ActionResult Delete(Aluno model)
        {
            try
            {   
                if (ModelState.IsValid)
                {
                    var aluno = alunoRN.ListarTodos().Where(x => x.Id == model.Id).FirstOrDefault();
                    var retorno = alunoRN.Deletar(aluno);
                    if (retorno == "")
                        RedirectToAction("index");
                    else
                        return View(model);
                }
                else
                {
                    return View(model);
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
