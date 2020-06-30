using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Cliente
    {
        private Pessoa cliente;
        private Endereco endereco;

        public void CadastraCliente(Pessoa newcliente, Endereco newendereco)
        {
            this.cliente = newcliente;
            this.endereco = newendereco;

        }

        public void ListarCliente() {

            Console.WriteLine();
            Console.WriteLine("CLIENTE:");
            Console.WriteLine("DADOS PESSOAIS DO CLIENTE");
            Console.WriteLine();
            Console.WriteLine("NOME DO CLIENTE: {0} \nCÓDIGO DO CLIENTE: {1} \nCONTATO DO CLIENTE: {2} ",this.cliente.MostrarCliente(0),this.cliente.MostrarCliente(1), this.cliente.MostrarCliente(2));
            Console.WriteLine("DADOS DE ENDEREÇO DO CLIENTE");
            
            Console.WriteLine("RUA: {0} \nNÚMERO: {1} \nCEP: {2} \nCIDADE: {3} \nESTADO: {4} ", this.endereco.MostrarEndereco(0), this.endereco.MostrarEndereco(1), this.endereco.MostrarEndereco(2), this.endereco.MostrarEndereco(3), this.endereco.MostrarEndereco(4));
            Console.WriteLine();
            Console.WriteLine();

        } 
    }
}

