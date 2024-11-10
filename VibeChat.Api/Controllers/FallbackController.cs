using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace VibeChat.Api.Controllers
{
    public class FallbackController : Controller
    {
        public ActionResult Index()
        {
            return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/browser","index.html"),"text/HTML");
        }
    }
}
