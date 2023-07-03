using Generate_QrCode;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class RenderQrCodeModel : PageModel
{
    private readonly ILogger<RenderQrCodeModel> _logger;

    public RenderQrCodeModel(ILogger<RenderQrCodeModel> logger)
    {
        _logger = logger;
    }

    public string imageSource = "";

    public void OnPost(string content)
    {
        imageSource = QrCodeServices.BitmapToImageSource(Request.Form["ContentQrCode"]);
    }
}