using Microsoft.AspNetCore.Mvc;

namespace MinimalApi.Controllers
{
   
    [ApiController]
    [Route("opt")]
    public class IController : Controller
    {
        protected AccessData dati;
        public IController(AccessData dati) { this.dati = dati; }
      
       
        [HttpDelete]
        [Route("Reset")]
        public void reset()
        {
            dati.resetDati();
        }


    }
}
