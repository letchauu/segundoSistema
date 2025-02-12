using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundoSistema
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //operadores lógicos
            // && - retorna true se ambas as instruções forem verdadeiras
            // || - retorna true se  1 das instruções for verdadeira
            // ! - reverter o resultado, retorna False se o resultado for verdadeiro

            //int x = 5;
            //Console.WriteLine(x > 3 && x < 10); //ambos verdadeiros

            //int y = 5;
            //Console.WriteLine(y > 6 || y < 10); //1 tem que ser verdadeiro

            //int z = 5;
            //Console.WriteLine(!(z > 3 && z < 10)); //inverte a resposta

            //string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //Console.WriteLine("O comprimento da string de texto é: " + txt.Length); // ele conta a quantidade de caractere na variavel 

            //string txt = "Hello Word";
            //Console.WriteLine(txt.ToUpper()); //"HELLO WORD"
            //Console.WriteLine(txt.ToLower()); //"hello word"

            string primeiroNome = "Ana";
            string segundoNome = " Maria";
            string nome = primeiroNome + segundoNome;   //concatenação de string (texto)
            Console.WriteLine(nome);

            string primeiroNome1 = "Ana";
            string segundoNome1 = " Maria";
            string nome1 = string.Concat(primeiroNome1, segundoNome1); //concatenação de string (texto)
            Console.WriteLine(nome1);

            string meuTexto = "Olá";
            Console.WriteLine(meuTexto[2]); //cadeia de acesso, busca dentro da variavel o indice indicado pelo numero

            string meuTexto1 = "Olá";
            Console.WriteLine(meuTexto1.IndexOf("l"));//cadeia  de acesso, busca dentro da variavel o indice indicado pela letra

            string texto = "O Empreenda Senac é uma grande \"Oportunidade\" de adquirir conhecimento";
            Console.WriteLine(texto);

            Console.WriteLine(texto);





        }
    }
}
