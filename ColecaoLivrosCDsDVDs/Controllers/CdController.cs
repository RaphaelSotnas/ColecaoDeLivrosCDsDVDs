﻿using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Servico.CDs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Controllers
{
    public class CdController : Controller
    {
        private readonly ICdServico _cdServico;
        public CdController(ICdServico cdServico)
        {
            _cdServico = cdServico;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PaginaCadastrarCd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarCd(CdRequest cdrequest)
        {
            var cd = MapearCd(cdrequest);

            _cdServico.CadastrarCd(cd);

            return RedirectToAction("ListarCds");
        }

        private CD MapearCd(CdRequest cdrequest)
        {
            return new CD
            {
                Cantor = cdrequest.Cantor,
                GeneroMusical = cdrequest.GeneroMusical,
                Nome = cdrequest.Nome,
                Status = cdrequest.Status
            };
        }

        [HttpGet]
        public IActionResult PaginaEditarCd(int id)
        {
            if (id == 0)
                return BadRequest();

            var cd = _cdServico.BuscarCdPorId(id);
            if (cd == null)
                return NotFound();

            return View(cd);
        }

        [HttpPost]
        public IActionResult EditarCd(CD cd)
        {
            try
            {
                _cdServico.AtualizarCd(cd);
                return RedirectToAction("ListarCds");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult ListarCds()
        {
            try
            {
                var cds = _cdServico.ListarCds();
                return View(cds);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [HttpGet]
        public IActionResult PaginaDetalhesCd(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();

                var cd = _cdServico.BuscarCdPorId(id);
                if (cd == null)
                    return NotFound();

                return View(cd);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    
        [HttpGet]
        public IActionResult PaginaExcluirCd(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();

                var cd = _cdServico.BuscarCdPorId(id);
                if (cd == null)
                    return NotFound();

                return View(cd);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        public IActionResult ExcluirCd(int id)
        {
            try
            {
                _cdServico.ExcluirCd(id);
                return RedirectToAction("ListarCds");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
