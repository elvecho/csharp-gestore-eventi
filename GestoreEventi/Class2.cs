using System;
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
            Console.WriteLine("ecco il tuo programma eventi: ");
            Console.WriteLine(Titolo);
            foreach (Evento EventoNellaLista in eventi)
            {
                Console.WriteLine(EventoNellaLista.ToString());
            }
            
        }
        public string getTitolo()
        {
            return Titolo;
        }
       public int NumeroEventi()
        {
          int numero = eventi.Count;
            return numero;
          }

        public void Clear()
        {
            eventi.Clear();
        }
        public void listaEventi(DateTime data)
        {
          foreach(Evento Evento in eventi)
            {
                if(Evento.getdata() == data)
                {
                    Console.WriteLine(Evento.ToString());
                }
            }
               
            }
          
        }
      
    }

