using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MinimalApi.Model;

namespace MinimalApi.Controllers
{
    [Route("api/get")]
    [ApiController]
    public class getController : IController
    {
     
        public getController(AccessData dati):base(dati){ }
        public async void Index()
        {
            dati.addUtenti(new Utente { nome = "luca", cognome = "frangiamore", indirizzo = "123" });
            dati.addUtenti(new Utente { nome = "peier", cognome = "gttg", indirizzo = "12233" });
            dati.addEmail(2, new NEmail { email = "perit@.com" });
            dati.addEmail(1, new NEmail { email = "lucafr434aa@.com" });
            dati.addNumero(1, new NTelefono { numero = 12343 });

        }
        [HttpGet]
        [Route("Utente")]
        public async Task<IEnumerable<Utente>> getUtenti()
        {
            return dati.getUtenti().Result;
        }
        [HttpGet]
        [Route("Email")]
        public async Task<IEnumerable<NEmail>> getEmail(int idUtente)
        {
            return dati.getEmail(idUtente).Result;
        }
        [HttpGet]
        [Route("Telefono")]
        public async Task<IEnumerable<NTelefono>> getTelefono(int idUtente)
        {
            return dati.getNumero(idUtente).Result; 
        }

    }
}
