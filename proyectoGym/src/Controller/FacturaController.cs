using Microsoft.EntityFrameworkCore;
using src.Model.Personas;
using ProyectoGym.src.Model.Context;
using src.Model.Finanzas;
using src.Model.Gestion;

namespace ProyectoGym.src.Controller
{
    public class FacturaController 
    {
        private readonly GymContext _context;

        public FacturaController(GymContext context)
        {
            _context = context;
        }

        public async Task<List<Factura>> ListarFacturas()
        {
            return await _context.Facturas
            .Include(m => m.Cliente)
            .ToListAsync();
        }

        public async Task<Factura?> Details(int? id)
        {
            if (id == null)
            {

            }

            var factura = await _context.Facturas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (factura == null)
            {

            }

            return factura;
        }

        public async Task<int> facturar(Factura Factura, int ClienteId)
        {
            var cliente = await _context.Personas.FirstOrDefaultAsync(p => p.ID == ClienteId);
            if (cliente == null)
            {
                throw new Exception("Cliente no encontrado."+ ClienteId);
            }

            Factura.ClienteId = ClienteId;
            _context.Facturas.Add(Factura);

            return await _context.SaveChangesAsync();
        }

        public async Task<Membresia?> obtenerMembresia(int clienteId)
        {
            return await _context.Membresias.FirstOrDefaultAsync(m => m.ClienteID == clienteId);
        }

        // GET: Clientes/Create
        /*public IActionResult Create()
        {
            return View();
        }


        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TipoUsuario,FechaNacimiento,NombreCompleto,Contraseña,CorreoElectronico,NombreUsuario,Telefono,Rol")] Cliente cliente)
        {
            if (id != cliente.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.ID))
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
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.ID == id);
        }*/
    }
}
