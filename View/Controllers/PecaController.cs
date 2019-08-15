using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interfaces;

namespace View.Controllers
{
    [Route("peca/")]
    public class PecaController : Controller
    {
        private IPecaRepository repository;

        public PecaController(IPecaRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("inserir")]
        public JsonResult Inserir([FromForm]Peca peca)
        {
            var id = repository.Inserir(peca);
            return Json(new { id });
        }

        [HttpPost, Route("alterar")]
        public JsonResult Alterar([FromForm]Peca peca)
        {
            var alterado = repository.Alterar(peca);
            return Json(new { alterado });
        }

        [HttpGet, Route("apagar")]
        public JsonResult Apagar(int id)
        {
            var apagou = repository.Apagar(id);
            return Json(new { status = apagou });
        }

        [HttpGet, Route("obtertodos")]
        public ActionResult ObterTodos()
        {
            var pecas = repository.ObterTodos();
            return Json(new { data = pecas });
        }

        [HttpGet, Route("obtertodosselect2")]
        public JsonResult ObterTodosSelect2(string term = "")
        {
            term = term == null ? "" : term;

            var registros = repository.ObterTodos();

            registros = registros.Where(x => x.Nome.Contains(term)).ToList();
            var pecasSelect2 = new List<object>();
            foreach(var peca in registros)
            {
                pecasSelect2.Add(new
                {
                    id = peca.Id,
                    text = peca.Nome
                });
            }
            return Json(new { results = pecasSelect2 });
        }

        [HttpGet, Route("obterpeloid")]
        public ActionResult ObterPeloId(int id)
        {
            var peca = repository.ObterPeloId(id);
            return Json(peca);
        }
    }
}