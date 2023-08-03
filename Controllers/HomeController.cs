using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MinimalApi.Model;

namespace MinimalApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class HomeController : Controller
    {
     
        private AccessData dati;
        public HomeController(AccessData dati) { this.dati = dati; }
        public async void Index()
        {
            dati.addUtenti(new Utente { name = "luca", cognome = "frangiamore", indirizzo = "123" });
            dati.addUtenti(new Utente { name = "peier", cognome = "gttg", indirizzo = "12233" });
            dati.addEmail(2, new NEmail { email = "perit@.com" });
            dati.addEmail(1, new NEmail { email = "lucafr434aa@.com" });
            dati.addNumero(1, new NTelefono { numero = 12343 });

        }
        [HttpGet]
        [Route("getUtenti")]
        public async Task<IEnumerable<Utente>> getUtenti()
        {
            return dati.getUtenti().Result;
        }
        [HttpGet]
        [Route("getEmail")]
        public async Task<IEnumerable<NEmail>> getEmail(int idUtente)
        {
            return dati.getEmail(idUtente).Result;
        }
        [HttpGet]
        [Route("getTelefoni")]
        public async Task<IEnumerable<NTelefono>> getTelefono(int idUtente)
        {
            return dati.getNumero(idUtente).Result; 
        }

    }
}
