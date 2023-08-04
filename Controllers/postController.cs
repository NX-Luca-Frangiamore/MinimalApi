using Microsoft.AspNetCore.Mvc;
using MinimalApi.Model;

namespace MinimalApi.Controllers
{
    [Route("api/post")]
    [ApiController]
  
    public class postController : IController
    {
        public postController(AccessData dati) : base(dati) { }
        public string Index()
        {
            return @"End Point disponibili:
                    /Utente(_nome,_cognome,_indirizzo)
                    /Email(_uteneId,_email)
                    /Telefono(_utenteId,_numero)
                    ";
        }
        [HttpPost]
        [Route("Utente")]
        public async void addUtenti(string _nome,string _cognome,string _indirizzo)
        {
            dati.addUtenti(new Utente { nome = _nome, cognome = _cognome, indirizzo = _indirizzo });
        }
        [HttpPost]
        [Route("Email")]
        public async void addEmail(int _utenteId,string _email)
        {
            dati.addEmail(_utenteId,new NEmail { email=_email});
        }
        [HttpPost]
        [Route("Telefono")]
        public async void addTelefono(int utenteId, int _numero)
        {
             dati.addNumero(utenteId, new NTelefono { numero = _numero });
        }
    }
}
