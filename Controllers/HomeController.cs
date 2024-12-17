using DavrazElektromobil.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UniversityCommunity.Controllers
{
    public class HomeController : Controller
    {
        private readonly CommunityDbContext _context;

        // Constructor ile DbContext inject edilir
        public HomeController(CommunityDbContext context)
        {
            _context = context;
        }

        // Anasayfa g�sterimi
        public IActionResult Index()
        {
            // Veritaban�ndan TeamMembers tablosunun ilk 3 �yesini �ekiyoruz
            var teamMembers = _context.TeamMembers.Take(6).ToList(); // �lk 3 �ye

            var model = new HomeViewModel
            {
                Quote = "\"D�nyada her �ey i�in medeniyet i�in, hayat i�in ba�ar� i�in en ger�ek yol g�sterici ilimdir, fendir.\"",
                Author = "Mustafa Kemal Atat�rk",
                IntroText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s...",
                AboutText = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC...",
                TeamMembers = teamMembers // Veritaban�ndan gelen veri buraya atan�r
            };

            return View(model);
        }

        // T�m tak�m �yelerini g�steren sayfa
        public IActionResult Members()
        {
            var teamMembers = _context.TeamMembers.ToList(); // B�t�n �yeleri al�yoruz
            return View(teamMembers);  // Members.cshtml sayfas�na y�nlendirece�iz
        }
    }
}
