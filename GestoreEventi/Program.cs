// See https://aka.ms/new-console-template for more information
using GestoreEventi;
Console.WriteLine("Hello, World!");

Console.WriteLine("ciao, vuoi inserire un nuovo evento? si/no");
string risposta = Console.ReadLine();
if (risposta == "si")
{
    Console.Write("inserisci il nome dell' evento: ");
    string titolo = Console.ReadLine();
    Console.Write("inserisci la data dell' evento (gg/mm/yyyy): ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Console.Write("inserisci il numero di posti totali: ");
    int numerodipostiTot = int.Parse(Console.ReadLine());
    Console.Write("quanti posti vuoi prenotare? ");
    int postiPrenotati = int.Parse(Console.ReadLine());

    Evento Nuovoevento = new Evento(titolo, data, numerodipostiTot);
    try
    {
        Nuovoevento.SetData(data);
    }
    catch
    {
        Console.WriteLine("la data è nel passato");
    }
    try
    {
        Nuovoevento.setTitolo(titolo);
    }
    catch
    {
        Console.WriteLine("il titolo non può essere vuoto");
    }
    try
    {
        Nuovoevento.setCapienzaMax(numerodipostiTot);
        try
        {
            Nuovoevento.AggiungiPosto(postiPrenotati, data);
        }
        catch
        {
            Console.WriteLine("stai prenotando troppi posti o la data dell evento è passata");
            postiPrenotati = 0;
        } 
       
    }
    catch
    {
        postiPrenotati= 0;
       
        Console.WriteLine("il numero non può essere negativo");
    }
        
    Nuovoevento.ToString();
    

    
   for(int i = 0; i < postiPrenotati; i++)
    {
        Console.Write("vuoi disdire posti? (si/no) ");
        string risposta2 = Console.ReadLine();
        if(risposta2 == "si" )
        {
            Console.Write("indica il numero di posti da disdire: ");
            int postiDaDisdire = int.Parse(Console.ReadLine());
            try
            {
                Nuovoevento.DisdiciPosti(postiDaDisdire, data);
            }
            catch
            {
                Console.WriteLine("stai disdicendo troppi posti o la data dell evento è passata ");
            }
        }
        else
        {
            Console.WriteLine("ok va bene!");
            
            break;

        }
    }

}
else
{
    Console.WriteLine("ok va bene!");
} 

Console.WriteLine("inserisci il nome del tuo programma eventi: ");
string nome = Console.ReadLine();
Console.WriteLine("inserisci quanti eventi vuoi aggiungere");
int NuomeroDiEventi = int.Parse(Console.ReadLine());
ProgrammaEventi NuovoProgrammaEventi = new ProgrammaEventi(nome);

for (int i = 1; i < NuomeroDiEventi + 1; i++)
{
    Console.WriteLine("inserisci il nome del " + i + "° evento: ");
    string nomeEvento = Console.ReadLine();
    Console.WriteLine("inserisci la data dell' evento (gg/mm/yyyy): ");
    DateTime data = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("inserisci il numero di posti totali: ");
    int postitotali = int.Parse(Console.ReadLine());

    Evento Nuovoevento = new Evento(nomeEvento, data, postitotali);
    try
    {
        Nuovoevento.SetData(data);
        NuovoProgrammaEventi.AggiungiEvento(Nuovoevento);
    }
    catch
    {

        {
            i--;
            Console.WriteLine("la data è nel passato");
        }

    }
    
}
Console.WriteLine(NuovoProgrammaEventi.NumeroEventi());
    NuovoProgrammaEventi.stampaLista();
Console.Write("inserisci una data per sapere che eventi ci saranno (gg/mm/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
NuovoProgrammaEventi.listaEventi(date);

//NuovoProgrammaEventi.Clear();
//NuovoProgrammaEventi.stampaLista();



