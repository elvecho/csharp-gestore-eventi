// See https://aka.ms/new-console-template for more information
using GestoreEventi;
Console.WriteLine("Hello, World!");

Console.WriteLine("ciao caro vuoi inserire un nuovo evento? si/no");
string risposta = Console.ReadLine();
if (risposta == "si")
{
    Console.WriteLine("ottimo, qual è il titolo?");
    string titolo = Console.ReadLine();
    Console.WriteLine("a quale data corrisponde?");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("inserisci il numero di posti totale");
    int numerodipostiTot = int.Parse(Console.ReadLine());
    Console.WriteLine("quanti posti vuoi prenotare?");
    int postiPrenotati = int.Parse(Console.ReadLine());

    Evento Nuovoevento = new Evento(titolo, data, numerodipostiTot);
    Nuovoevento.ToString();
    Nuovoevento.AggiungiPosto(postiPrenotati, data);
Nuovoevento.stampaPosti();
    bool trovato = false;
   for(int i = 0; i < postiPrenotati; i++)
    {
        Console.WriteLine("vuoi disdire posti? (si/no) ");
        string risposta2 = Console.ReadLine();
        if(risposta2 == "si")
        {
            Console.WriteLine("indica il numero di posti da disdire: ");
            int postiDaDisdire = int.Parse(Console.ReadLine());
            Nuovoevento.DisdiciPosti(postiDaDisdire, data);
            Nuovoevento.stampaPosti();
        }
        else
        {
            Console.WriteLine("ok va bene!");
            Nuovoevento.stampaPosti();
            break;

        }
    }

}
else
{
    Console.WriteLine("ok va bene!");
}


