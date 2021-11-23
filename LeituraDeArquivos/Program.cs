using System;
using System.IO;

namespace LeituraDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string linha;
            try
            {
                //StreamWriter sw = new StreamWriter("C:\\Teste\\teste.txt"); //Escrita - Writer
                StreamReader sr = new StreamReader("C:\\Teste\\teste.txt");
                linha = sr.ReadLine(); //aqui leio a primeira linha
                while (linha != null) //se tem algo na primeira linha, entro no laço
                {
                    Console.WriteLine(linha); // mostro a linha lida
                    linha = sr.ReadLine(); //aqui vai ler a próxima linha
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }

        }
    }
}
