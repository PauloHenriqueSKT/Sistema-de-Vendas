using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    abstract class Funcionario
    {
        protected int codigo;
        protected string nome;
        protected string cpf;
        protected string contato;

        public void CadastraFuncionario(int codigo, string nome, string cpf, string contato)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.cpf = cpf;
            this.contato = contato;



        }

        public string MostrarFuncionario(int valor)
        {

            String[] lista = { this.nome, Convert.ToString(this.codigo), this.cpf, this.contato };

            string a = lista[valor];


            return a;

        }
                   
        public float CalculaComissao(float valor) {

            float valorComissao = valor;
            return valorComissao;
        
        
        }


    }


    class Vendedor : Funcionario
    {


        

       

        private float percentualcomissao = 10;

        public float CalculaComissao(float valor)
        {

            float valorComissao = valor*(this.percentualcomissao/100);
            return valorComissao;
        }

       



    }

    class Gerente : Funcionario 
    {
        private float percentualcomissao = 25;

        public float CalculaComissao(float valor)
        {

            float valorComissao = valor * (this.percentualcomissao / 100);
            return valorComissao;
        }

       


    }

    class Entregador : Funcionario
    {

        private int totalentregas=50;

        public void listaentregas() {

            
            Console.WriteLine("O total de entregas é: {0}",  this.totalentregas);
        
        }

        



    }
}
