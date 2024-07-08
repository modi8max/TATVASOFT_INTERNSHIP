using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentPortal.web.Data;
using StudentPortal.web.Models;

namespace StudentPortal.web.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext dbContext;

        public StudentController(AppDbContext dbContext) 
        {
            this.dbContext=dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddStudentViewModel viewModel)
        {
            var student = new Student
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Branch = viewModel.Branch,
                Phone = viewModel.Phone,
            };
            await dbContext.Students.AddAsync(student);
            await dbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var students = await dbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var student = await dbContext.Students.SingleOrDefaultAsync(s => s.Id == id);
            return View(student);
        }

        [HttpPost]

        public async Task<IActionResult> Edit(Student viewModel)
        {
            var student = await dbContext.Students.FindAsync(viewModel.Id);
            if(student != null)
            {
                student.Name = viewModel.Name;
                student.Email = viewModel.Email;
                student.Branch = viewModel.Branch;
                student.Phone = viewModel.Phone;

                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List","Student");
        }

        [HttpPost]

        public async Task<IActionResult> Delete(Student viewModel)
        {
            var student = await dbContext.Students.AsNoTracking().FirstOrDefaultAsync(s => s.Id == viewModel.Id);

            if (student != null)
            {
                dbContext.Students.Remove(viewModel);
            }
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Student");
        }
    }
}
