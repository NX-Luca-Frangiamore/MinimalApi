using Microsoft.AspNetCore.Authentication;
using System;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using MinimalApi.Model;

namespace MinimalApi.Services
{
    public class Autenticazione : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IAccessData db;
        public Autenticazione(Microsoft.Extensions.Options.IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IAccessData db) : base(options, logger, encoder, clock)
        {
            this.db = db;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string richiesta = Request.Headers["Authorization"].ToString();//prendo il campo Authorization 

            if (richiesta == "")
            {
                Response.StatusCode = 401;
                return await Task.FromResult(AuthenticateResult.Fail("credenziali non corrette"));

            }
            richiesta = richiesta.Substring("basic".Length).Trim();// tolgo Basic, gli spazi al inizio e alla fine
            richiesta = Encoding.UTF8.GetString(Convert.FromBase64String(richiesta));
            Console.WriteLine(richiesta);
            string[] parametri = richiesta.Split(':');
            Utente utente = await db.getUtente(parametri[0], parametri[1]);
            if (utente == null)
            {
                Response.StatusCode = 401;
                return await Task.FromResult(AuthenticateResult.Fail("credenziali non corrette"));
            }
            Console.WriteLine(richiesta);
            Claim[] cs = { new Claim("nome", parametri[0]), new Claim("cognome", parametri[1]), new Claim("id", utente.id + "") };
            ClaimsIdentity identity = new ClaimsIdentity(cs, Scheme.Name);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            return await Task.FromResult(AuthenticateResult.Success(new AuthenticationTicket(principal, Scheme.Name)));

        }
    }
}
