using Microsoft.AspNetCore.Mvc.RazorPages;

public class LibroModel : PageModel
{
    private readonly ILogger<LibroModel> _logger;

    public LibroModel(ILogger<LibroModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}