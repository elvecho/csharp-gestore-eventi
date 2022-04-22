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
        public DateTime setData(DateTime nuovadata)
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
        public void AggiungiPosto(int quantitàDiPostiDaAggiungere)
        {
            if(postiPrenotati + quantitàDiPostiDaAggiungere > capienzaMax)
            {
                Console.WriteLine("mi spiace ma non ci sono più posti disponibili");
            }
            else
            {
                postiPrenotati = postiPrenotati + quantitàDiPostiDaAggiungere;
                Console.WriteLine("i tuoi posti sono stati aggiunti");
            }    
        }
        public void DisdiciPosti(int quantitàDiPostiDaDisdire)
        {
            if(postiPrenotati - quantitàDiPostiDaDisdire < 0)
            {
                Console.WriteLine("stai disdicendo troppi posti");
            }
            else
            {
                postiPrenotati = postiPrenotati - quantitàDiPostiDaDisdire;
                Console.WriteLine("hai disdetto correttamente i tuoi posti");
            }
        }

    }
}
