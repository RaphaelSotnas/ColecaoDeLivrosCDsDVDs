using ColecaoLivrosCDsDVDs.Models.Contrato;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Servico.DVDs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Controllers
{
    public class DvdController : Controller
    {
        private readonly IDvdServico _dvdServico;
        public DvdController(IDvdServico dvdServico)
        {
            _dvdServico = dvdServico;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult PaginaCadastrarDvd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarDvd(DvdRequest dvdRequest)
        {
            var dvd = MapearParaDvd(dvdRequest);

            _dvdServico.CadastrarDvd(dvd);

            return RedirectToAction("ListarDvds");
        }

        private DVD MapearParaDvd(DvdRequest dvdRequest)
        {
            return new DVD
            {
                Genero = dvdRequest.Genero,
                Nome = dvdRequest.Nome,
                Status = dvdRequest.Status
            };
        }

        [HttpGet]
        public IActionResult ListarDvds()
        {
            try
            {
                var dvds = _dvdServico.ListarDvds();
                return View(dvds);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [HttpGet]
        public IActionResult PaginaEditarDvd(int id)
        {
            if (id == 0)
                return BadRequest();

            var dvd = _dvdServico.BuscarDvdPorId(id);
            if (dvd == null)
                return NotFound();

            return View(dvd);
        }

        [HttpPost]
        public IActionResult EditarDvd(DVD dvd)
        {
            try
            {
                _dvdServico.AtualizarDvd(dvd);
                return RedirectToAction("ListarDvds");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public IActionResult PaginaExcluirDvd(int id)
        {
            try
            {
                if (id == 0)
                    return BadRequest();

                var dvd = _dvdServico.BuscarDvdPorId(id);
                if (dvd == null)
                    return NotFound();

                return View(dvd);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        [HttpPost]
        public IActionResult ExcluirDvd(int id)
        {
            try
            {
                _dvdServico.ExcluirDvd(id);
                return RedirectToAction("ListarDvds");
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
    }
}
