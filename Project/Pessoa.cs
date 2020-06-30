using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Pessoa
    {
        private int codigo;
        private string nome;
        private string contato;

        public void CadastrarPessoa(int codigo, string nome, string contato) {
            this.codigo = codigo;
            this.nome = nome;
            this.contato = contato;
        }
        public string MostrarCliente(int valor)
        {
            String[] lista = { this.nome, Convert.ToString(this.codigo), Convert.ToString(this.contato) };

            string a = lista[valor];

         
            return a;

        }

    }
}
