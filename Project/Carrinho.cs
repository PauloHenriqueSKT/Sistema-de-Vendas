using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Carrinho
    {
        private Cliente cliente;
        private Vendedor vendedor;
        private List<Produto>  listadecompras;

        public Carrinho(Cliente cliente, Vendedor vendedor)
        {
            this.cliente = cliente;
            this.vendedor = vendedor;

         }
        public void EtiquetaProduto(List <Produto> produtos) 
        {
            this.listadecompras = produtos;

        
        }

        public  float TotalCompra() {

            float valorcompra=0;

            foreach(Produto produto in this.listadecompras)
            {
                valorcompra += float.Parse(produto.MostrarProduto(2));
            }
            return valorcompra;
        }


        public float CalculaComissao(float valorcompra) {
            float valorcomissao;

           valorcomissao = this.vendedor.CalculaComissao(valorcompra);
            return valorcomissao;
                                              
        
        }
    }

    
}
