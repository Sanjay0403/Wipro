using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiproDemoRazerPages.Model;

namespace WiproDemoRazerPages.Pages
{
    public class EmployeeModel : PageModel
    {
        [BindProperty]
        public Employee emps { get; set; } = new Employee();

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["Message"]=$"Hello {emps.Name}";
            return Page();
        }

    }
}
