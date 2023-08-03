﻿using MinimalApi.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MinimalApi
{
    public class AccessMysqlite : AccessData
    {
        public AccessMysqlite(Context context):base(context) { }
        public override void addEmail(int idUtente, NEmail email)
        {
            context.nemail.Add(email);
            context.SaveChanges();
        }

        public override async void addNumero(int idUtente, NTelefono numero)
        {
            context.ntelefono.Add(numero);
            context.SaveChanges();
        }

        public override async void addUtenti(Utente utente)
        {
            context.utente.Add(utente);
            context.SaveChanges();
        }

        public override async Task<IEnumerable<NEmail>> getEmail(int idUtente)
        {
            return context.nemail.Where(x => x.utenteId == idUtente);
        }

        public override async Task<IEnumerable<NTelefono>> getNumero(int idUtente)
        {
            return context.ntelefono.Where(x => x.utenteId == idUtente);
        }

        public override async Task<IEnumerable<Utente>> getUtenti()
        {
            return context.utente;
        }
    }
}