using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Fornecedor
    {
        private int codigo;
        private string razaoSocial;
        private Contato contato;


        public void CadastrarFornecedor(int codigo, string razaoSocial, Contato contato) {

            this.codigo = codigo;
            this.razaoSocial = razaoSocial;
            this.contato = contato;
    }

        public string MostrarFornecedor(int valor) {
            String[] lista = { Convert.ToString(this.codigo), this.razaoSocial, Convert.ToString(this.contato) };

            string mostrafornecedor = lista[valor];


            return mostrafornecedor;

        }

        public string MostrarContatoFornecedor(int valor) {

            string contato = this.contato.MostrarContato(valor);

            return contato;
        }

    }
}
