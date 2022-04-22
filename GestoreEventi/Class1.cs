using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienzaMax;
        private int postiPrenotati;

        public Evento(string titolo, DateTime data, int capienzaMAx)
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
            return nuovotitolo;
        }
        public DateTime SetData(DateTime nuovadata)
        {
           return nuovadata;
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
            if(postiPrenotati + quantitàDiPostiDaAggiungere > capienzaMax ^ oraAttuale < dataevento)
            {
                Console.WriteLine("mi spiace ma non ci sono più posti disponibili o la data non è corretta");
            }
            else
            {
                postiPrenotati = postiPrenotati + quantitàDiPostiDaAggiungere;
                Console.WriteLine("i tuoi posti sono stati aggiunti");
                Console.WriteLine("numero di posti prenotati - " + postiPrenotati);
            }    
        }
        public void DisdiciPosti(int quantitàDiPostiDaDisdire,  DateTime dataevento)
        {
            DateTime oraAttuale = DateTime.Now;
            if(postiPrenotati - quantitàDiPostiDaDisdire < 0 ^ oraAttuale < dataevento)
            {
                Console.WriteLine("stai disdicendo troppi posti o la data non è corretta");
            }
            else
            {
                postiPrenotati = postiPrenotati - quantitàDiPostiDaDisdire;
                Console.WriteLine("hai disdetto correttamente i tuoi posti");
                Console.WriteLine("numero di posti prenotati: " + postiPrenotati);
            }
        }
        public virtual string ToString()
        {
            data.ToString("dd/MM/yyyy");
            string rappresentazioneInStringa = "";
            rappresentazioneInStringa += "---- evento ---- \n";
            rappresentazioneInStringa += "data: " + this.data + "titolo: " + this.titolo;
            return rappresentazioneInStringa;

        }
        public void stampaPosti()
        {
           
            Console.WriteLine("numero di posti disponibili - " + (capienzaMax - postiPrenotati));
        }
    }
}
