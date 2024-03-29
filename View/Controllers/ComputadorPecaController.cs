﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository.Interfaces;

namespace View.Controllers
{
    [Route("computadorpeca/")]
    public class ComputadorPecaController : Controller
    {
        IComputadorPecaRepository repository;

        public ComputadorPecaController(IComputadorPecaRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, Route("relacionar")]
        public JsonResult Relacionar(ComputadorPeca computadorPeca)
        {
            int id = repository.Relacionar(computadorPeca);
            return Json(new { id });
        }

        [HttpGet, Route("apagar")]
        public JsonResult Apagar(int id)
        {
            var apagado = repository.Apagar(id);
            return Json(new { status = apagado });
        }

        [HttpGet, Route("obtertodos")]
        public JsonResult ObterTodos(int idComputador)
        {
            return Json(new { data = repository.ObterTodosPeloIdComputador(idComputador) });
        }
    }
}