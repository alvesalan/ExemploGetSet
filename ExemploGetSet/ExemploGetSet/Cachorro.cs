using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGetSet
{
    class Cachorro
    {
        // publica de qualquer lugar
        // private apenas a mesma classe
        // Set  -> definir a informação 
        // Set tem como objetivo guardar determinada informação, validando a mesma ou não

        private string Nome;
        private string Raca;
        private double Peso;
        private double Altura;

        public void SetNome(string nome)
        {
            if (nome.Count() < 3)
            {
                throw new Exception("Nome deve conter 3 letras");
            }

            if (nome.Count() > 40)
            {
                throw new Exception("Nome deve conter no maximo 40 caracteres");
            }
            Nome = nome;
        }

        public void SetAltura(double altura)
        {
            if (altura <= 0)
            {
                throw new Exception("Altura deve ser maior que 0");
            }
            if (altura > 2)
            {
                throw new Exception("Altura deve ser menor que 2 metros");
            }
            Altura = altura;

        }

        public void SetPeso(double peso)
        {
            if (peso <= 0)
            {
                throw new Exception("Peso tem que ser maior que 0 kl");
            }
            if (peso > 100)
            {
                throw new Exception("Peso não pode ser maior que 100 kl");
            }
        }

        public void SetRaca(string raca)
        {
            if (raca.Count() < 3)
            {
                throw new Exception("Raca deve ter no minimo 3 caracter");
            }
            if (raca.Count() > 30)
            {
                throw new Exception("Raça deve ter no maximo 30 caracter");
            }


        }

        // obter a informação guardada 
        public string GetNome()
        {
            return Nome;
        }

        public double GetAltura()
        {
            return Altura;
        }
        public double GetPeso()
        {
            return Peso;
        }
        public string GetRaca()
        {
            return Raca;
        }
    }
}
000000000000000000000000000000000000000