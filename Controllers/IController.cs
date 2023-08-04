using Microsoft.AspNetCore.Mvc;

namespace MinimalApi.Controllers
{
    [Route("/")]
    [ApiController]
    public abstract class IController : Controller
    {
        protected AccessData dati;
        public IController(AccessData dati) { this.dati = dati; }
      
        
    }
}
