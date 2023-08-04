using Microsoft.AspNetCore.Mvc;
using MinimalApi.Model;

namespace MinimalApi.Controllers
{
    [Route("api/post")]
    [ApiController]
  
    public class postController : IController
    {
        public postController(AccessData dati) : base(dati) { }
        
        [HttpPost]
        [Route("Utente")]
        public async void addUtenti(string _nome,string _cognome,string _indirizzo)
        {
            dati.addUtenti(new Utente { nome = _nome, cognome = _cognome, indirizzo = _indirizzo });
        }
        [HttpPost]
        [Route("Email")]
        public async void addEmail(string _email,int _utenteId)
        {
            dati.addEmail(_utenteId,new NEmail { email=_email});
        }
        [HttpPost]
        [Route("Telefono")]
        public async void addTelefono(int idUtente, int _numero)
        {
             dati.addNumero(idUtente, new NTelefono { numero = _numero });
        }
    }
}
