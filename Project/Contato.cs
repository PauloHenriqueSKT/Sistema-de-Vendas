using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Contato
    {
        private int codigo;
        private string nomefornecedor;
        private string email;
        public void CadastrarContato(int codigo, string nome, string email)
        {


            this.codigo = codigo;
            this.nomefornecedor = nome;
            this.email = email;
        }

        public string MostrarContato(int valor) {

            String[] lista = { Convert.ToString(this.codigo), this.nomefornecedor, this.email };

            string a = lista[valor];


            return a;

        }

    }

}
    

