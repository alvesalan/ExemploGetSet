using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro dogao = new Cachorro();
            dogao.SetNome("Spok");
            dogao.SetAltura(1.10);
            dogao.SetPeso(100);
            dogao.SetRaca("dswsfsf");

            Console.WriteLine(" Nome: " + dogao.GetNome() + "\n Raça: " + dogao.GetRaca() + "\n Altura: " + dogao.GetAltura() + "\n Peso: " + dogao.GetPeso());
        }
    }
}
