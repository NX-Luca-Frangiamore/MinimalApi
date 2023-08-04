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
        public  string Index()
        {
            return @"End Point disponibili:
                    /Utenti
                    /Email 
                    /Telefoni 
                    ";
        }
        [HttpGet]
        [Route("Utenti")]
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
        [Route("Telefoni")]
        public async Task<IEnumerable<NTelefono>> getTelefono(int idUtente)
        {
            return dati.getNumero(idUtente).Result; 
        }

    }
}
