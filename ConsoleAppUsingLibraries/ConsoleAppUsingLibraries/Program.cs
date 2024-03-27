using RegexUtils;

namespace ConsoleAppUsingLibraries
{
    internal class Program
    {
        static int sceltaUtente;

        static void Main(string[] args)
        {
            try
            {
                SceltaUtente();
                do
                {
                    switch (sceltaUtente)
                    {
                        case 1:
                            Console.WriteLine("Inserisci un indirizzo email");
                            String email = Console.ReadLine();
                            Console.WriteLine("L'indirizzo email è {0}", RegexUtils.Class1.IsValidEmail(email) ? "valido" : "non valido\n");
                            SceltaUtente();
                            break;

                        case 2:
                            Console.WriteLine("Inserisci nome e cognome in questo formato:\n" +
                                "Nome: John Cognome: Doe");
                            String userInput = Console.ReadLine();
                            (String nome, String cognome) = RegexUtils.Class1.GetPersonalData(userInput);
                            Console.WriteLine($"Nome: {nome}, Cognome: {cognome}\n");
                            SceltaUtente();
                            break;

                        case 3:
                            Console.WriteLine("Inserisci una frase con la tua altezza, o solo la tua altezza, in metri, compresa di punto o virgola");
                            String altezza = Console.ReadLine();
                            Console.WriteLine(RegexUtils.Class1.HeightConversion(altezza) + "\n");
                            SceltaUtente();
                            break;

                        case 4:
                            Console.WriteLine("Scrivi una frase");
                            String frase = Console.ReadLine();
                            Console.WriteLine("Digita la vocale che vuoi prenda il sopravvento");
                            char vocale = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine(RegexUtils.Class1.MonoVocalizzazione(frase, vocale) + "\n");
                            SceltaUtente();
                            break;

                        default:
                            break;
                    }
                }
                while (sceltaUtente != 9);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static public void SceltaUtente()
        {
            Console.WriteLine("Seleziona l'operazione da eseguire\n" +
                "1.Validazione indirizzo email\n" +
                "2.Estrazione nome e cognome\n" +
                "3.Conversione altezza da metri a cm\n" +
                "4.Conversione vocali\n" +
                "9.Esci dal programma");
            sceltaUtente = int.Parse(Console.ReadLine());
        }
    }
}
