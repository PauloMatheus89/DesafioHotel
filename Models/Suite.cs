using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Suite
    {
        public Suite(int capacidade, string tipoSuite)
        {
            Capacidade = capacidade;
            TipoSuite = tipoSuite;
        }

        private int _capacidade;
        private decimal _valorDiaria;
        private string _tipoSuite;
        public string TipoSuite
        {
            get => _tipoSuite;

            set
            {
                switch (value.ToUpper())
                {
                    case "LUXO":
                        _valorDiaria = 300M;
                        break;
                    case "SIMPLES":
                        _valorDiaria = 200M;
                        break;
                    case "REQUINTADA":
                        _valorDiaria = 400M;
                        break;

                    default:
                        throw new ArgumentException("Tipo de Suíte inválido!");

                }

                _tipoSuite = value;
            }
        }

        public int Capacidade
        {
            get => _capacidade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A capacidade deve ser maior que 0");
                }
                _capacidade = value;
            }       
        }

        public decimal ValorDiaria { get => _valorDiaria; }
    }
}