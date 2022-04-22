﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        string Titolo;
        List<Evento> eventi;

        public ProgrammaEventi(string Titolo)
        {
            this.Titolo = Titolo;
            this.eventi = new List<Evento>();
        }
        public void AggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }
        public void stampaLista()
        {
            foreach (Evento EventoNellaLista in eventi)
            {
                Console.WriteLine(EventoNellaLista.ToString());
            }
            
        }

    }
}