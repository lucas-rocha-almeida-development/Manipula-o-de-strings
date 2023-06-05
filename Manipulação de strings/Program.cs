using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulação_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {// manipulação de strings
            Console.WriteLine("MANIPULAÇÃO DE STRING");
            string nome = "Lucas";
            // indexação de string
            char letra = nome[4];
            Console.WriteLine("A letra que esta na posição 6 (indice) é : " + letra);
            Console.WriteLine("\n");
            //cima ira imprimir a letra S
            Console.WriteLine("---------------------------Concatenar de STRING-----------------------\n");
            string Sobrenome = " Rocha Almeida";
            //podemos ver que foi feito concatenação das strings nome e nome completo
            string nomeCompleto = nome + Sobrenome;
            Console.WriteLine("Nome completo do usuario:" + nomeCompleto + "\n");
            Console.WriteLine("Existe esse metodo Concat tambem funcional: ");
            string NomeMetodoConcat = String.Concat(nome, Sobrenome +"\n");
            Console.WriteLine(NomeMetodoConcat);
            Console.WriteLine("------------------------SUBSTITUIÇÃO DE STRING----------------------");
            string endereço = "Rua Daniel Mello Batista";
            //Vamos substituir o nome Batista por Sobrinho
            //usando o metodo replace (substituir)
            //passo o primeiro valor (que sera excluido,valor que entrara no lugar);
            endereço= endereço.Replace("Batista","\'Sobrinho\'");
            Console.WriteLine("Resultado da substituição do metodo replace " + endereço);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------REMOÇÃO DA STRING---------------");
            string RemovendoString = "Neymar da silva Junior";
            Console.WriteLine("Nome antes da utilização do replace: " + RemovendoString);
            RemovendoString = RemovendoString.Replace("Junior","\'\'");
            Console.WriteLine("Nome apos utilização do replace: " + RemovendoString);
            Console.WriteLine('\n');
            Console.WriteLine("----------------------METODO REMOVE-----------");
            //METODO REMOVE,  A PARTIR DO INDICE X , REMOVA QUANTIDADE DE INDICES 4
            string MetodoRemove = "Ronaldo Nazario de Lima";
            MetodoRemove = MetodoRemove.Remove(19,4);
            Console.WriteLine(MetodoRemove);
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------------------------------------");
            //LETRAS MINUSCULAS PARA TOUPPER()

            string MaiusculoTrans = "lionel messi";
            MaiusculoTrans = MaiusculoTrans.ToUpper();
            Console.WriteLine("Ira pegar o valor da string e converter para MAIUSCULO: " + MaiusculoTrans);
            Console.WriteLine("\n");

            Console.WriteLine("-------------------METODO CONTEM ALGO NA STRING-----------------");
            string ContemPalavra = "Quem acredita sempre alcança";
            bool verificaSeComtem = ContemPalavra.Contains("acredita");
            Console.WriteLine(verificaSeComtem);
            Console.WriteLine("\n");
            Console.WriteLine("-----------------VERIFICAR INDICE DO TEXTO-POSIÇÃO INDEX-----------------");
            string PosicaoIndexTexto = "Verifique posição do index desse texto";
            int CapturaOINDEX = PosicaoIndexTexto.IndexOf("desse");
            Console.WriteLine("O indice da palavra selecionada se encontra na posição: " + CapturaOINDEX);
            Console.WriteLine("\n");
            Console.WriteLine("--------------------DIVIDINDO UM STRING-----------------");
            string DividindoString = "Luan Rocha Almeida";// minha string recebeu esse valor
            string[] divisores = {"Rocha"};//minha string sera dividida a partir do nome Rocha
            string[] resultadoDivisãoPalavra = DividindoString.Split(divisores,StringSplitOptions.None);
            foreach(string ChamadaNome in resultadoDivisãoPalavra)//pegue os valores do resultado da divisão e jogue para string ChamadaNome
            {

                Console.WriteLine("Foi removido a palavra rocha e feito a separação " + ChamadaNome);
                //ira imprimir Luan Almeida, pelo fato de ser retirado a palavra Rocha
            }
            //numero de caracteres
            Console.WriteLine("\n");
            Console.WriteLine("--------------------PEGANDO NUMERO DE CARACTERES-----------------------");
            string QuantidadeCaracteres = "Carlos Alberto Torres";
            int numerodecaracteres = QuantidadeCaracteres.Length;
            Console.WriteLine("Ira Imprimir a quantidade de caracteres: "+ numerodecaracteres);
            Console.ReadKey();
        }
    }
}
