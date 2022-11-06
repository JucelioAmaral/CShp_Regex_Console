using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CShp_Regex_Console
{
    public class clsMainExemplosRegexCPF
    {

        public void RegexCPF()
        {
            Console.WriteLine("-------------- OUTRO EXEMPLO DE REGEX --------------\n");
            //ARTIGO: https://www.alura.com.br/artigos/regex-c-sharp-utilizar-expressoes-regulares?gclid=EAIaIQobChMI46etla-Q-wIVUg6tBh0G_wsHEAAYASAAEgIhrvD_BwE

            Console.WriteLine("-----Verificação numerica -----\n");
            Console.Write("Informe um valor:  ");
            var caracteres = Console.ReadLine();
            bool ok = Regex.IsMatch(caracteres, "^[0-9]+$");
            if (!ok)
            {
                Console.WriteLine("O valor informado não é um numérico válido.");
            }
            else
            {
                Console.WriteLine("O valor informado é válido.");
            }

            Console.WriteLine();
            Console.WriteLine("-----Validação de CPF -----\n");
            Console.Write("Informe um cpf para validação: ");
            var cpf = Console.ReadLine();            
            Regex regex = new Regex(@"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)", RegexOptions.IgnoreCase);
            var combinou = regex.Match(cpf);
            if (combinou.Success)
            {
                Console.WriteLine("CPF no formato válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }

            Console.WriteLine();
            Console.Write("Usando o .IsMatch()\n");
            Console.Write("Informe um cpf para validação: ");
            var cpf2 = Console.ReadLine();
            Regex regex2 = new Regex(@"([0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", RegexOptions.IgnorePatternWhitespace);
            if (regex2.IsMatch(cpf2))
            {
                Console.WriteLine("CPF válido.");
            }
            else
            {
                Console.WriteLine("CPF inválido.");
            }


            Console.WriteLine();
            Console.Write("Usando o .Match()\n");
            var busca = "Mergulhando em tecnologia com a Alura.";
            Regex regex3 = new Regex("Alura", RegexOptions.IgnoreCase); Match match = regex3.Match(busca);
            if (match.Success) { 
                Console.WriteLine("string encontrada no texto.");
            }
            else
            {
                Console.WriteLine("string não encontrada.");
            }
        }
    }
}
