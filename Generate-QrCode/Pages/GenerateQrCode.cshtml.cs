using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Generate_QrCode.Pages;

public class GenerateQrCodeModel : PageModel
{
    private readonly ILogger<GenerateQrCodeModel> _logger;

    public GenerateQrCodeModel(ILogger<GenerateQrCodeModel> logger)
    {
        _logger = logger;
    }

    [Required(ErrorMessage="Please inform the content of the qrcod!")]
    public string ContentQrCode { get; set; } = null!;

    public void OnGet()
    {
    }
}
