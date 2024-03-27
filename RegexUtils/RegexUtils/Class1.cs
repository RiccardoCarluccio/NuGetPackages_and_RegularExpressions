using System.Text.RegularExpressions;

namespace RegexUtils
{
    public class Class1
    {
        private static readonly Regex EmailRegex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", RegexOptions.Compiled);

        private static readonly Regex AnagraficaRegex = new Regex(@"Nome: (?<nome>\w+) Cognome: (?<cognome>\w+)", RegexOptions.Compiled);

        private static readonly Regex AltezzaRegex = new Regex(@"[.,]", RegexOptions.Compiled);

        private static readonly Regex MonoVocalizzazioneARegex = new Regex(@"[eiouEIOU]");
        private static readonly Regex MonoVocalizzazioneERegex = new Regex(@"[aiouAIOU]");
        private static readonly Regex MonoVocalizzazioneIRegex = new Regex(@"[aeouAEOU]");
        private static readonly Regex MonoVocalizzazioneORegex = new Regex(@"[aeiuAEIU]");
        private static readonly Regex MonoVocalizzazioneURegex = new Regex(@"[aeioAEIO]");

        //Validazione email
        public static bool IsValidEmail(String email)
        {
            return EmailRegex.IsMatch(email);
        }

        //Estrazione nome e cognome
        public static (String, String) GetPersonalData(String input)
        {
            Match match = AnagraficaRegex.Match(input);

            if (match.Success)
            {
                String nome = match.Groups["nome"].Value;
                String cognome = match.Groups["cognome"].Value;

                return (nome, cognome);
            }
            else
            {
                return (String.Empty, String.Empty);
            }
        }

        //Conversione altezza da metri a centimetri
        public static String HeightConversion(String input)
        {
            String altezzaConvertita = AltezzaRegex.Replace(input, "");
            String nuovaAltezza;
            return nuovaAltezza = (altezzaConvertita + "cm");
        }

        //Sostituzione di tutte le vocali con una a scelta
        public static String MonoVocalizzazione(String input, char c)
        {
            char c2 = char.ToLower(c);

            if (c2 == 'a')
            {
                return MonoVocalizzazioneARegex.Replace(input, "a");
            }
            else if (c2 == 'e')
            {
                return MonoVocalizzazioneERegex.Replace(input, "e");
            }
            else if (c2 == 'i')
            {
                return MonoVocalizzazioneIRegex.Replace(input, "i");
            }
            else if (c2 == 'o')
            {
                return MonoVocalizzazioneORegex.Replace(input, "o");
            }
            else if (c2 == 'u')
            {
                return MonoVocalizzazioneURegex.Replace(input, "u");
            }
            return "";
        }
    }
}
