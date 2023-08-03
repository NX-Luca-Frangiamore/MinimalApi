using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MinimalApi.Model;

namespace MinimalApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
     
        private AccessData dati;
        public HomeController(AccessData dati) { this.dati = dati; }
        public IEnumerable<Utente> Index()
        {
            dati.addUtenti(new Utente(1, "luca", "frangiamore"));
        }
    }
}
