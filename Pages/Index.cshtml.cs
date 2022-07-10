using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hello_cloudfront.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string Message
    {
        get => DateTime.Now.ToString();
    }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
