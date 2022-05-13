using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AfrosoftInterns.Models;

namespace AfrosoftInterns.Controllers
{
    public class InternController : Controller
    {
        private readonly InternContext _context;

        public InternController(InternContext context)
        {
            _context = context;
        }

        // GET: Intern
        public async Task<IActionResult> Index()
        {
            return View(await _context.Interns.ToListAsync());
        }

        // GET: Intern/Create
        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            return View(new Intern());
            else
            return View(_context.Interns.Find(id));
        }

        // POST: Intern/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Id,FullName,Sex,Email,Department,Specialty")] Intern intern)
        {
            if (ModelState.IsValid)
            {
                if (intern.Id == 0)
                    _context.Add(intern);
                else
                    _context.Update(intern);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(intern);
        }

        // GET: Intern/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var intern = await _context.Interns.FindAsync(id);
            _context.Interns.Remove(intern);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
