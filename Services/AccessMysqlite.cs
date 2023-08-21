using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MinimalApi.Model;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MinimalApi.Services
{
    public class AccessMysqlite : IAccessData
    {
        public AccessMysqlite(Context context) : base(context) { }
        public override void addEmail(int idUtente, NEmail email)
        {
            email.utenteId = idUtente;
            context.nemail.Add(email);
            context.utente.Find(idUtente).emails.Add(email);
            context.SaveChanges();
        }

        public override async void addNumero(int idUtente, NTelefono telefono)
        {
            telefono.utenteId = idUtente;
            context.ntelefono.Add(telefono);
            context.utente.Find(idUtente).telefoni.Add(telefono);
            context.SaveChanges();
        }

        public override async void addUtenti(Utente utente)
        {
            context.utente.Add(utente);
            context.SaveChanges();
        }

        public override async Task<IQueryable<NEmail>> getEmail(int idUtente)
        {
            //  return context.nemail.Where(x => x.utenteId == idUtente);
            return context.utente.Include(u => u.emails).Where(x => x.id == idUtente).SelectMany(x => x.emails);
        }

        public override async Task<IQueryable<NTelefono>> getNumero(int idUtente)
        {
            //    return context.ntelefono.Where(x => x.utenteId == idUtente);
            return context.utente.Include(u => u.telefoni).Where(x => x.id == idUtente).SelectMany(x => x.telefoni);
        }

        public override async Task<Utente> getUtente(string nome, string cognome)
        {
            return context.utente.Where(x => x.nome == nome && x.cognome == cognome).FirstOrDefault();
        }

        public override async Task<IQueryable<Utente>> getUtenti()
        {
            return context.utente.Include(u => u.emails).Include(u => u.telefoni);
        }

        public override void resetDati()
        {
            context.utente.ExecuteDeleteAsync();
            context.nemail.ExecuteDeleteAsync();
            context.ntelefono.ExecuteDeleteAsync();
            context.SaveChanges();
        }
    }
}
