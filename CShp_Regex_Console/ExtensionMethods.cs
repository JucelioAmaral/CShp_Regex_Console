using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CShp_Regex_Console
{
    public static class ExtensionMethods
    {
        public static Match LocalizaOcorrencia(this string fonte, string padrao, int ocorrencia)
        {
            if (ocorrencia < 1)
            {
                throw (new ArgumentException("Não pode ser menor que 1", nameof(ocorrencia)));
            }
            // torna ocorrencia zero-based.
            --ocorrencia;
            // Executa o regex uma vez na fonte
            Regex RE = new Regex(padrao, RegexOptions.Multiline);

            MatchCollection correspondencias = RE.Matches(fonte);

            if (ocorrencia >= correspondencias.Count)
            {
                return (null);
            }
            else
            {
                return (correspondencias[ocorrencia]);
            }
        }

        public static List<Match> LocalizaCadaOcorrencia(this string fonte, string padrao, int ocorrencia)
        {
            if (ocorrencia < 1)
            {
                throw (new ArgumentException("Não pode ser menor que 1", nameof(ocorrencia)));
            }

            List<Match> ocorrencias = new List<Match>();


            Regex RE = new Regex(padrao, RegexOptions.Multiline);

            MatchCollection correspondencias = RE.Matches(fonte);

            for (int index = (ocorrencia - 1); index < correspondencias.Count; index++)
            {
                ocorrencias.Add(correspondencias[index]);
            }
            return (ocorrencias);
        }

        public static int NumeroOcorrencias(this string fonte, string padrao)
        {
            List<Match> ocorrencias = new List<Match>();

            Regex RE = new Regex(padrao, RegexOptions.Multiline);

            MatchCollection correspondencias = RE.Matches(fonte);

            if (correspondencias.Count > 0)
            {
                return correspondencias.Count;
            }
            else
            {
                return 0;
            }
        }
    }
}
