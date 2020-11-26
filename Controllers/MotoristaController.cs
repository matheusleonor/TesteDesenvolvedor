using CadastroMotorista.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroMotorista.Controllers
{
    public class MotoristaController : Controller
    {
        private readonly Contexto _contexto;

        public MotoristaController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _contexto.Motoristas.ToListAsync());
        }

        [HttpGet]
        public IActionResult CriarMotorista()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarMotorista(Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                _contexto.Add(motorista);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            else return View(motorista);
        }

        [HttpGet]
        public IActionResult AtualizarMotorista(int? id)
        {
            if (id != null)
            {
                Motorista motorista = _contexto.Motoristas.Find(id);
                return View(motorista);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarMotorista(int? id,Motorista motorista)
        {
            if (id != null)
            {
                if (ModelState.IsValid)
                {
                    _contexto.Update(motorista);
                    await _contexto.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else return View(motorista);
            }

            else return NotFound();

        }

        [HttpGet]
        public IActionResult ExcluirMotorista(int? id)
        {
            if (id != null)
            {
                Motorista motorista = _contexto.Motoristas.Find(id);
                return View(motorista);
            }
            else return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> ExcluirMotorista(int? id, Motorista motorista)
        {
            if (id != null)
            {
                _contexto.Remove(motorista);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            else return NotFound();

        }

    }
}
