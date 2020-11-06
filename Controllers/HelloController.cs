using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        [HttpGet]
        
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" + 
                "<input type='text' name='name' />" +
                "<select id='language' name='language'>" +
                    "<option value='english'>English</option>" +
                    "<option value='spanish'>Espanol</option>" +
                    "<option value='german'>Deutsch</option>" +
                    "<option value='french'>Francais</option>" +
                    "<option value='italian'>Italiano</option>" + 
                "<input type='submit' value='Greet Me!' />" + 
                "</form>";
            return Content(html, "text/html");
        }

        // GET: /hello/Welcome
        // [HttpGet]
        // [Route("/helloworld/welcome/{name?}")]
        [Route("/helloworld")]
        [HttpPost]

        public IActionResult Welcome(string name = "World", string language = "english")
        {
            if (language == "spanish")
            {
                return Content("<h1>Bienvenida a mi aplicacion, " + name + "!</h1>", "text/html");
            }

            if (language == "german")
            {
                return Content("<h1>Willkommen in meiner App, " + name + "!</h1>", "text/html");
            }

            if (language == "french")
            {
                return Content("<h1>Bienvenue sur mon appli, " + name + "!</h1>", "text/html");
            }

            if (language == "italian")
            {
                return Content("<h1>Benvenuto nella mia app, " + name + "!</h1>", "text/html");
            }

            else 
            {
                return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
            }
        }
    }
}
