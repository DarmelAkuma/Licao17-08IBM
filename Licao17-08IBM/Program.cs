using System;

namespace Licao17_08IBM {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Qual a divisão do animal? (vertebrado ou invertebrado)");
            string divisão = Console.ReadLine();
            Console.WriteLine("Qual a classe do animal? (ave, mamifero, inseto ou anelideo)");
            string classe = Console.ReadLine();
            Console.WriteLine("Qual é a cadeia alimentar do animal? (carnivoro, onivoro, herbivoro ou hematofago)");
            string cAlimentar = Console.ReadLine();

            if (divisão == "vertebrado" && classe == "ave" && cAlimentar == "carnivoro") {
                Console.WriteLine("Este animal é a aguia!");
            }

            else if (divisão == "vertebrado" && classe == "ave" && cAlimentar == "onivoro") {
                Console.WriteLine("Este animal é a pomba!");
            }
            else if (divisão == "vertebrado" && classe == "mamifero" && cAlimentar == "onivoro") {
                Console.WriteLine("Este animal é o homem!");
            }
            else if (divisão == "vertebrado" && classe == "mamifero" && cAlimentar == "herbivoro") {
                Console.WriteLine("Este animal é a vaca!");
            }

            if (divisão == "invertebrado" && classe == "inseto" && cAlimentar == "hematofago") {
                Console.WriteLine("Este animal é a pulga!");
            }

            else if (divisão == "invertebrado" && classe == "inseto" && cAlimentar == "herbivoro") {
                Console.WriteLine("Este animal é a lagarta!");
            }
            else if (divisão == "invertebrado" && classe == "anelideo" && cAlimentar == "hematofago") {
                Console.WriteLine("Este animal é a sanguessuga!");
            }
            else if (divisão == "invertebrado" && classe == "anelideo" && cAlimentar == "onivoro") {
                Console.WriteLine("Este animal é a minhoca!");
            }
        }
    }
}
