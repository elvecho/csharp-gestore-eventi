using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento : ProgrammaEventi
    {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMAx) : base(titolo)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMax = capienzaMAx;
            postiPrenotati = 0;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public DateTime getdata()
        {
           
            return data;
        }
        public string setTitolo(string nuovotitolo)
        {
            if(nuovotitolo == "")
            {
                throw new ArgumentException("il titolo non puo essere vuoto");
            }
            return nuovotitolo;
        }
        public DateTime SetData(DateTime nuovadata)
        {
            DateTime dataAttuale = DateTime.Now;
            if (dataAttuale > nuovadata)
            {
                
                throw new ArgumentException("la data è nel passato");
            }
            return nuovadata;
        }
        public int setCapienzaMax(int capienza)
        {
            if (capienzaMax < 0)
            {
                throw new ArgumentException("il numero non può essere negativo");
            }
            return capienzaMax;
        }
        public int GetCapienzaMax()
        {
            return capienzaMax;
        }
        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }
        //metodi
        public void AggiungiPosto(int quantitàDiPostiDaAggiungere, DateTime dataevento)

        {
           DateTime oraAttuale = DateTime.Now;
            if(postiPrenotati + quantitàDiPostiDaAggiungere > capienzaMax ^ oraAttuale > dataevento)
            {
                throw new ArgumentException("stai prenotando troppi posti, oppure la data è passata");
            }
            else
            {
                postiPrenotati = postiPrenotati + quantitàDiPostiDaAggiungere;
                Console.WriteLine("i tuoi posti sono stati aggiunti");
                Console.WriteLine("numero di posti prenotati - " + postiPrenotati);
                Console.WriteLine("numero di posti disponibili - " + (capienzaMax - postiPrenotati));

            }    
        }
        public void DisdiciPosti(int quantitàDiPostiDaDisdire,  DateTime dataevento)
        {
            DateTime oraAttuale = DateTime.Now;
            if(postiPrenotati - quantitàDiPostiDaDisdire < 0 ^ oraAttuale > dataevento)
            {
                throw new ArgumentException("stai disdicendo troppi posti, oppure la data è passata");
            }
            else
            {
                postiPrenotati = postiPrenotati - quantitàDiPostiDaDisdire;
                Console.WriteLine("hai disdetto correttamente i tuoi posti");
                Console.WriteLine("numero di posti prenotati: " + postiPrenotati);
                Console.WriteLine("numero di posti disponibili - " + (capienzaMax - postiPrenotati));
            }
        }
        public virtual string ToString()
        {
            data.ToString("dd/MM/yyyy");
            string rappresentazioneInStringa = "";
           
            rappresentazioneInStringa += data.ToString("dd/MM/yyyy")+ " " + "titolo: " + this.titolo;
            return rappresentazioneInStringa;

        }
        
    }
}
