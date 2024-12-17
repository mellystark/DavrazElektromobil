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

        // Anasayfa gösterimi
        public IActionResult Index()
        {
            // Veritabanýndan TeamMembers tablosunun ilk 3 üyesini çekiyoruz
            var teamMembers = _context.TeamMembers.Take(6).ToList(); // Ýlk 3 üye

            var model = new HomeViewModel
            {
                Quote = "\"Dünyada her þey için medeniyet için, hayat için baþarý için en gerçek yol gösterici ilimdir, fendir.\"",
                Author = "Mustafa Kemal Atatürk",
                IntroText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s...",
                AboutText = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC...",
                TeamMembers = teamMembers // Veritabanýndan gelen veri buraya atanýr
            };

            return View(model);
        }

        // Tüm takým üyelerini gösteren sayfa
        public IActionResult Members()
        {
            var teamMembers = _context.TeamMembers.ToList(); // Bütün üyeleri alýyoruz
            return View(teamMembers);  // Members.cshtml sayfasýna yönlendireceðiz
        }
    }
}
