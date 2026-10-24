using Academic_Administration_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Academic_Administration_System.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();

            return View(students);
        }

        // GET: Students/Create
[HttpGet]
public IActionResult Create()
{
    return View();
}

// POST: Students/Create
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Create(
    Academic_Administration_System.Models.Student student)
{
    if (ModelState.IsValid)
    {
        bool emailExists = await _context.Students
            .AnyAsync(s => s.Email == student.Email);

        if (emailExists)
        {
            ModelState.AddModelError(
                "Email",
                "This email is already registered."
            );

            return View(student);
        }

        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    return View(student);
}

// GET: Students/Edit/1
[HttpGet]
public async Task<IActionResult> Edit(int id)
{
    var student = await _context.Students.FindAsync(id);

    if (student == null)
    {
        return NotFound();
    }

    return View(student);
}

// GET: Students/Delete/1
[HttpGet]
public async Task<IActionResult> Delete(int id)
{
    var student = await _context.Students.FindAsync(id);

    if (student == null)
    {
        return NotFound();
    }

    return View(student);
}

// POST: Students/Delete/1
[HttpPost, ActionName("Delete")]
[ValidateAntiForgeryToken]
public async Task<IActionResult> DeleteConfirmed(int id)
{
    var student = await _context.Students.FindAsync(id);

    if (student == null)
    {
        return NotFound();
    }

    _context.Students.Remove(student);

    await _context.SaveChangesAsync();

    return RedirectToAction(nameof(Index));
}

// POST: Students/Edit/1
[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Edit(
    int id,
    Academic_Administration_System.Models.Student student)
{
    if (id != student.StudentID)
    {
        return NotFound();
    }

    if (ModelState.IsValid)
    {
        bool emailExists = await _context.Students
            .AnyAsync(s => s.Email == student.Email
                        && s.StudentID != student.StudentID);

        if (emailExists)
        {
            ModelState.AddModelError(
                "Email",
                "This email is already registered."
            );

            return View(student);
        }

        var existingStudent = await _context.Students.FindAsync(id);

        if (existingStudent == null)
        {
            return NotFound();
        }

        existingStudent.FirstName = student.FirstName;
        existingStudent.LastName = student.LastName;
        existingStudent.Email = student.Email;
        existingStudent.PhoneNumber = student.PhoneNumber;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    return View(student);
}
    }
}