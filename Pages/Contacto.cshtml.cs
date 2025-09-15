using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiProyectoRazorPages.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public string? Nombre { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        public void OnGet()
        {
            // Método para solicitudes GET
        }

        public IActionResult OnPost()
        {
            // Método para solicitudes POST
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Procesar el formulario
            return RedirectToPage("/Index");
        }
    }
}