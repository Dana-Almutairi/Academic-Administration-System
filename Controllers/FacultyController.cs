using Academic_Administration_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academic_Administration_System.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Faculty
        public async Task<IActionResult> Index()
        {
            var facultyMembers = await _context.Faculty.ToListAsync();

            return View(facultyMembers);
        }

        // GET: Faculty/Create
[HttpGet]
public IActionResult Create()
{
    return View();
}

// POST: Faculty/Create
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create(
    Academic_Administration_System.Models.Faculty faculty)
{
    if (ModelState.IsValid)
    {
        bool emailExists = await _context.Faculty
            .AnyAsync(f => f.Email == faculty.Email);

        if (emailExists)
        {
            ModelState.AddModelError(
                "Email",
                "This email is already registered."
            );

            return View(faculty);
        }

        _context.Faculty.Add(faculty);

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    return View(faculty);
}

// GET: Faculty/Edit/1
[HttpGet]
public async Task<IActionResult> Edit(int id)
{
    var faculty = await _context.Faculty.FindAsync(id);

    if (faculty == null)
    {
        return NotFound();
    }

    return View(faculty);
}

// POST: Faculty/Edit/1
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(
    int id,
    Academic_Administration_System.Models.Faculty faculty)
{
    if (id != faculty.FacultyID)
    {
        return NotFound();
    }

    if (ModelState.IsValid)
    {
        bool emailExists = await _context.Faculty
            .AnyAsync(f => f.Email == faculty.Email
                        && f.FacultyID != faculty.FacultyID);

        if (emailExists)
        {
            ModelState.AddModelError(
                "Email",
                "This email is already registered."
            );

            return View(faculty);
        }

        var existingFaculty = await _context.Faculty.FindAsync(id);

        if (existingFaculty == null)
        {
            return NotFound();
        }

        existingFaculty.FirstName = faculty.FirstName;
        existingFaculty.LastName = faculty.LastName;
        existingFaculty.Email = faculty.Email;
        existingFaculty.Department = faculty.Department;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    return View(faculty);
}

// GET: Faculty/Delete/1
[HttpGet]
public async Task<IActionResult> Delete(int id)
{
    var faculty = await _context.Faculty.FindAsync(id);

    if (faculty == null)
    {
        return NotFound();
    }

    return View(faculty);
}

// POST: Faculty/Delete/1
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var faculty = await _context.Faculty.FindAsync(id);

    if (faculty == null)
    {
        return NotFound();
    }

    _context.Faculty.Remove(faculty);

    await _context.SaveChangesAsync();

    return RedirectToAction(nameof(Index));
}
    }
}