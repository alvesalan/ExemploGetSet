using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioGetSet
{
    class Cabelo
    {
        private double TamanhoFio;
        private double GrossuraFio;
        private string CorFio;

    

    public void GetTamanho(double tamanhofio)
    {
        if (tamanhofio < 1)
        {
            throw new Exception("Tamanho do fio de cabelo não pode ser menor que 1 !!");
        }
        if (tamanhofio > 90)
        {
            throw new Exception("Tamanho do fio de cabelo não pode ser maior que 90 !!");
        }
        this.TamanhoFio = tamanhofio;
    }
        public void GetGrossuraFio(double grossurafio)
    {
        if (grossurafio < 0.1)
        {
            throw new Exception("Tamanho da grossura do fio de cabelo não pode ser menor que 1.0 !!");
        }
        if (grossurafio > 1.0)
        {
            throw new Exception("Tamanho da grossura do cabelo não pode ser maior que 1.0")
        }
            this.GrossuraFio = grossurafio;
    }
        public void GetCorFio(string corfio)
        {
            if (corfio.Count < 7)
            {
                throw new Exception("A quantidade de caracter da cor do fio de cabelo não pode ser menor que 7 !!");
            }
            if (corfio.Count > 20)
            {
                throw new Exception("A quantidade de caracter da cor do fio de cabelo não pode ser maior que 20 !!");
            }
            this.CorFio = corfio;
        }
       
        

    }
}
