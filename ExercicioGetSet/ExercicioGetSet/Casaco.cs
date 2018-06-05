using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGetSet
{
    class Casaco
    {
        private string Cor;
        private double Preco;
        private string Tamanho;

        public void GetCor(string cor)
        {
            if (cor.Count < 7)
            {
                throw new Exception("Cor deve ter no minimo 7 caracter !!");
            }
            if (cor.Count > 20)
            {
                throw new Exception("Cor deve ter no maximo 20 caracter !!");
            }

            this.Cor = cor;
        }
        public void GetPreco(double preco)
        {
            if (preco < 10)
            {
                throw new Exception("Preço minimo e de 10 R$");
            }
            if (preco > 900)
            {
                throw new Exception("Preço maximo e de 900 R$");
            }
            this.Preco = preco;
        }
        public void GetTamanho(string tamanho)
        {
            if (tamanho.Count < 1)
            {
                throw new Exception("Quantidade minima para tamanho e de 1 caracter !!");
            }
            if (tamanho > 3)
            {
                throw new Exception("Quantidade maxima para tamanho e de 3 caracter !!");
            }
            this.Tamanho = tamanho;
        }

    }

}
