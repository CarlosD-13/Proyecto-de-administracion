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
    public class PropiedadesController : Controller
    {
        private readonly PropiedadesContext _context;

        public PropiedadesController(PropiedadesContext context)
        {
            _context = context;
        }

        Propiedades _Propiedades = new Propiedades();

        // GET: Propiedades
        public async Task<IActionResult> Index()
        {
            return View(await _context.PropiedadesEN.ToListAsync());
        }

        // GET: Propiedades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
 

              if (id == null)
              {
                  return NotFound();
              }

              var propiedades = await _context.PropiedadesEN
                  .FirstOrDefaultAsync(m => m.InmuebleID == id);
              if (propiedades == null)
              {
                  return NotFound();
              }

            //string[] foto = propiedades.Imagen.Split("~");
            string foto = propiedades.Imagen;
            ViewBag.Fotos = foto;

              return View(propiedades);
              
            /*return View(await _context.PropiedadesEN.ToListAsync(propiedades));*/
        }

        // GET: Propiedades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Propiedades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InmuebleID,Nombre,Habitaciones,Baños,Parqueo,Opcion,Precio,Imagen,Observacion")] Propiedades propiedades)
        {
            if (ModelState.IsValid)
            {
                _context.Add(propiedades);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(propiedades);
        }

        // GET: Propiedades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedades = await _context.PropiedadesEN.FindAsync(id);
            if (propiedades == null)
            {
                return NotFound();
            }
            return View(propiedades);
        }

        // POST: Propiedades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InmuebleID,Nombre,Habitaciones,Baños,Parqueo,Opcion,Precio,Imagen,Observacion")] Propiedades propiedades)
        {
            if (id != propiedades.InmuebleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(propiedades);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PropiedadesExists(propiedades.InmuebleID))
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
            return View(propiedades);
        }

        // GET: Propiedades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var propiedades = await _context.PropiedadesEN
                .FirstOrDefaultAsync(m => m.InmuebleID == id);
            if (propiedades == null)
            {
                return NotFound();
            }

            return View(propiedades);
        }

        // POST: Propiedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var propiedades = await _context.PropiedadesEN.FindAsync(id);
            _context.PropiedadesEN.Remove(propiedades);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PropiedadesExists(int id)
        {
            return _context.PropiedadesEN.Any(e => e.InmuebleID == id);
        }
    }
}
