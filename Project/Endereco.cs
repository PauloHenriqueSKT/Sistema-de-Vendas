using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Endereco
    {
        private string rua;
        private string numero;
        private string cep;
        private string cidade;
        private string estado;

        public void CadastrarEndereco(string rua, string numero, string cep, string cidade, string estado) {

            this.rua = rua;
            this.numero = numero;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
        }
        public string MostrarEndereco(int valor)
        {
            String[] lista = { this.rua, this.numero, this.cep, this.cidade, this.estado };

            string mostrafornecedor = lista[valor];


            return mostrafornecedor;

        }
    }
}
