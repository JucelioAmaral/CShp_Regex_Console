using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CShp_Regex_Console
{
    public  class clsMainPoema
    {

        public void RegexPoema()
        {
            //PROJETO: https://macoratti.net/21/06/c_regexocesp1.htm        
            //POEMA: https://www.culturagenial.com/poema-em-linha-reta-de-alvaro-de-campos/

            string termo = "";
            int ocorrencia = 0;
            string arquivo = ConfigurationManager.AppSettings["CAMINHO DO ARQUIVO"];
            string poema = File.ReadAllText(arquivo);

            Console.Write("Usando Regex para localizar ocorrências em um texto\n");
            Console.WriteLine("Fonte: Poema de Fernando Pessoa: Poema em linha reta\n");

            //Console.ReadLine();
            //Console.WriteLine("Localizando o texto 'vezes' na terceira ocorrência\n");

            Console.WriteLine("Digite o termo que deseja procurar:");
            termo = Console.ReadLine();
            Console.WriteLine("Em relação a este termo, qual ocorrência deseja procurar?");
            ocorrencia = int.Parse(Console.ReadLine());
            Match resultado = poema.LocalizaOcorrencia(termo, ocorrencia);
            Console.WriteLine();
            Console.WriteLine("Resultado da busca em todo o texto pelo termo digitado:");
            int numOcorrencias1 = poema.NumeroOcorrencias(termo);
            Console.WriteLine($"A ocorrência {ocorrencia} foi encontrada na posicao : {resultado?.Index}\n");
            Console.WriteLine($"Foram encontradas {numOcorrencias1} ocorrências do termo " + termo + " digitado.\n");



            Console.WriteLine();
            Console.WriteLine("-------------- OUTRO EXEMPLO - Exibindo todas as posições de um termo específico --------------\n");
            Console.WriteLine("Localizando o texto 'sido' a partir da terceira ocorrência\n");
            int numOcorrencias2 = poema.NumeroOcorrencias("sido");
            List<Match> resultados = poema.LocalizaCadaOcorrencia("sido", 4);

            Console.WriteLine($"Foram encontradas {numOcorrencias2} ocorrências de 'sido' \n");
            Console.WriteLine("As ocorrências foram encontradas nas posições :");

            foreach (Match m in resultados)
                Console.WriteLine($"\t{m.Index}");

            //Console.ReadLine();
        }
    }
}
