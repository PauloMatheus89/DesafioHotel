using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public List<Pessoa> Hospedes { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //Método AddRange - Adciona todos os elemento de uma coleção em outra coleção
            Hospedes.AddRange(hospedes);
            if (Suite.Capacidade < ObterQuantidadeHospedes())
            {
                throw new ArgumentOutOfRangeException("O número de Hospedes excede a capacidade da Suíte!");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            return Suite.ValorDiaria;
        }
        public decimal CalcularValorTotal()
        {
            return Suite.ValorDiaria * DiasReservados;
        }
    }
}