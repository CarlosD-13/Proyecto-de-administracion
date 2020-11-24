using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyecto_Admin_Remix.Models;

namespace Proyecto_Admin_Remix.Controllers
{
    public class FormulariosController : Controller
    {
        private readonly PropiedadesContext _context;

        public FormulariosController(PropiedadesContext context)
        {
            _context = context;
        }

        // GET: Formularios
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formularios.ToListAsync());
        }

        // GET: Formularios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formularios = await _context.Formularios
                .FirstOrDefaultAsync(m => m.FormularioID == id);
            if (formularios == null)
            {
                return NotFound();
            }

            return View(formularios);
        }

        // GET: Formularios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Formularios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FormularioID,Cedula,Nombre,Apellido,correo,celular,telefono,Nacionalidad,Sexo,Fech_Naciemento,Estado_civil")] Formularios formularios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formularios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formularios);
        }

        // GET: Formularios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formularios = await _context.Formularios.FindAsync(id);
            if (formularios == null)
            {
                return NotFound();
            }
            return View(formularios);
        }

        // POST: Formularios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FormularioID,Cedula,Nombre,Apellido,correo,celular,telefono,Nacionalidad,Sexo,Fech_Naciemento,Estado_civil")] Formularios formularios)
        {
            if (id != formularios.FormularioID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formularios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormulariosExists(formularios.FormularioID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(formularios);
        }

        // GET: Formularios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formularios = await _context.Formularios
                .FirstOrDefaultAsync(m => m.FormularioID == id);
            if (formularios == null)
            {
                return NotFound();
            }

            return View(formularios);
        }

        // POST: Formularios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formularios = await _context.Formularios.FindAsync(id);
            _context.Formularios.Remove(formularios);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormulariosExists(int id)
        {
            return _context.Formularios.Any(e => e.FormularioID == id);
        }
    }
}
