using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;
        private string Nome
        {
            get => _nome.ToUpper();


            set
            {
                foreach (char caractere in value)
                {
                    if (!char.IsLetter(caractere))
                    {
                        throw new ArgumentException("Não são permitidos números ou caracteres especiais no Nome!");
                    }
                }

                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Valor do Nome não pode ser vazio!");
                }
                _nome = value;
            }
        }
        public string Sobrenome
        {
            get => _sobrenome.ToUpper();
            
            set
            {
                foreach (char caractere in value)
                {
                    if (!char.IsLetter(caractere))
                    {
                        throw new ArgumentException("Não são permitidos números ou caracteres especiais no Sobrenome!");
                    }
                }
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Valor do Sobrenome não pode ser vazio!");
                }

                _sobrenome = value;
            }
        }

        public string NomeCompleto
         {
            get => $"{Nome} {Sobrenome}";
         }

    }
}