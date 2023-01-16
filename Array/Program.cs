using System;
using System.IO.Pipes;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //primeiro exemplo de como criar uma array:
            //se define uma array com um valor x não pode alterar mais
            string[] produtos = new string[5]
            {"Sea of thieves", //0
             "FIFA", //1
             "Minecraft", //2
             "Half-Life", //3
             "Portal" }; //4
            
            //segundo exemplo de como criar uma array:
            int[] valores = { 40, 50, 60, 70, 20 };

            produtos[1] = "FIFA 2023"; //alterar o nome do produto
            Console.WriteLine(produtos[1]);

            Console.ReadLine();
        }
    }
}
