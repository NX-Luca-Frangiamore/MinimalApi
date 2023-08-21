using Microsoft.AspNetCore.Mvc;
using MinimalApi.Services;

namespace MinimalApi.Controllers
{

    [ApiController]
    [Route("opt")]
    public abstract class  IController : Controller
    {
        protected IAccessData dati;
        public IController(IAccessData dati) { this.dati = dati; }
      
       
        [HttpDelete]
        [Route("Reset")]
        public void reset()
        {
            dati.resetDati();
        }


    }
}
