using System.Diagnostics;
using DavrazElektromobil.Models;
using Microsoft.AspNetCore.Mvc;

namespace UniversityCommunity.Controllers
{
    public class HomeController : Controller
    {
        // Anasayfa g�sterimi
        public IActionResult Index()
        {
            var model = new HomeViewModel
            {
                Quote = "\"D�nyada her �ey i�in medeniyet i�in, hayat i�in ba�ar� i�in en ger�ek yol g�sterici ilimdir, fendir.\"",
                Author = "Mustafa Kemal Atat�rk",
                IntroText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book....",
                AboutText = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32....",
                TeamMembers = new List<TeamMember>
                {
                    new TeamMember { Name = "Yank� �ilingir", Role = "Tak�m Lideri", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSh4xRYEpGrse5vdKz0P_4XJGpE0IktXxIHrg&s" },
                    new TeamMember { Name = "Melike �akmako�lu", Role = "Tasar�m ve Yaz�l�m", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSh4xRYEpGrse5vdKz0P_4XJGpE0IktXxIHrg&s" },
                    new TeamMember { Name = "Sedef Altunay", Role = "�leti�im Sorumlusu", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSh4xRYEpGrse5vdKz0P_4XJGpE0IktXxIHrg&s" },
                    new TeamMember { Name = "Osman Arif Aslan", Role = "Ekip �yesi", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSh4xRYEpGrse5vdKz0P_4XJGpE0IktXxIHrg&s" }
                }
            };

            return View(model);
        }
    }
}
