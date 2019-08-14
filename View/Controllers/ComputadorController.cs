﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interfaces;

namespace View.Controllers
{
    [Route("computador/")]
    public class ComputadorController : Controller
    {
        private IComputadorRepository repository;

        public ComputadorController(IComputadorRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("inserir")]
        public ActionResult Inserir(Computador computador)
        {
            var id = repository.Inserir(computador);
            return RedirectToAction("Editar", new { id });
        }

        [HttpPost, Route("alterar")]
        public JsonResult Alterar(Computador computador)
        {
            var alterou = repository.Alterar(computador);
            return Json( new { status = alterou });
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
            return Json(repository.ObterTodos());
        }

        [HttpGet,Route("obterpeloid")]
        public ActionResult ObterPeloId(int id)
        {
            var computador = repository.ObterPeloId(id);
            if (computador == null)
                return NotFound();
            return Json(computador);
        }

        [HttpGet, Route("cadastro")]
        public ActionResult Cadastro()
        {
            return View();
        }
    }
}