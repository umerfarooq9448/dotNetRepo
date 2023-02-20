using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LibraryManagementSystemMilestone1.Models;

namespace LibraryManagementSystemMilestone1.Controllers
{
    public class BorrowsController : Controller
    {
        private readonly LMSContext _context;

        public BorrowsController(LMSContext context)
        {
            _context = context;
        }

        // GET: Borrows
        public async Task<IActionResult> Index()
        {
            var lMSContext = _context.Borrows.Include(b => b.Book).Include(b => b.Student);
            return View(await lMSContext.ToListAsync());
        }

        // GET: Borrows/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Borrows == null)
            {
                return NotFound();
            }

            var borrow = await _context.Borrows
                .Include(b => b.Book)
                .Include(b => b.Student)
                .FirstOrDefaultAsync(m => m.BorrowId == id);
            if (borrow == null)
            {
                return NotFound();
            }

            return View(borrow);
        }

        // GET: Borrows/Create
        public IActionResult Create()
        {
            //creating list of bookList and using it from viewbag in cshtml
            var booksList = (from book in _context.Books
                               select new SelectListItem()
                               {
                                   Text = book.BookName,
                                   Value = book.BookId.ToString(),
                               }).ToList();



            ViewBag.Listofbooks = booksList;


            //creating list of students and using it from viewbag in cshtml
            var studentsList = (from st in _context.Students
                               select new SelectListItem()
                               {
                                   Text = st.StudentFirstName,
                                   Value = st.StudentId.ToString(),
                               }).ToList();



            ViewBag.Listofstudents = studentsList;

            return View();

        }

        // POST: Borrows/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BorrowId,StudentId,BookId,TakenDate,BroughtDate")] Borrow borrow)
        {
            if (ModelState.IsValid)
            {
                _context.Add(borrow);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", borrow.BookId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", borrow.StudentId);
            return View(borrow);
        }

        // GET: Borrows/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Borrows == null)
            {
                return NotFound();
            }

            var borrow = await _context.Borrows.FindAsync(id);
            if (borrow == null)
            {
                return NotFound();
            }

            //creating list of books and using it from viewbag in cshtml
            var booksList = (from book in _context.Books
                             select new SelectListItem()
                             {
                                 Text = book.BookName,
                                 Value = book.BookId.ToString(),
                             }).ToList();



            ViewBag.Listofbooks = booksList;

            //creating list of students and using it from viewbag in cshtml
            var studentsList = (from st in _context.Students
                                select new SelectListItem()
                                {
                                    Text = st.StudentFirstName,
                                    Value = st.StudentId.ToString(),
                                }).ToList();



            ViewBag.Listofstudents = studentsList;
            


            return View(borrow);
        }

        // POST: Borrows/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BorrowId,StudentId,BookId,TakenDate,BroughtDate")] Borrow borrow)
        {
            if (id != borrow.BorrowId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(borrow);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BorrowExists(borrow.BorrowId))
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
            ViewData["BookId"] = new SelectList(_context.Books, "BookId", "BookId", borrow.BookId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "StudentId", borrow.StudentId);
            return View(borrow);
        }

        // GET: Borrows/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Borrows == null)
            {
                return NotFound();
            }

            var borrow = await _context.Borrows
                .Include(b => b.Book)
                .Include(b => b.Student)
                .FirstOrDefaultAsync(m => m.BorrowId == id);
            if (borrow == null)
            {
                return NotFound();
            }

            return View(borrow);
        }

        // POST: Borrows/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                if (_context.Borrows == null)
                {
                    return Problem("Entity set 'LMSContext.Borrows'  is null.");
                }
                var borrow = await _context.Borrows.FindAsync(id);
                if (borrow != null)
                {
                    _context.Borrows.Remove(borrow);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch(Exception ex)
            {
                return RedirectToAction(nameof(Index));

            }
            
        }

        private bool BorrowExists(int id)
        {
          return _context.Borrows.Any(e => e.BorrowId == id);
        }
    }
}
