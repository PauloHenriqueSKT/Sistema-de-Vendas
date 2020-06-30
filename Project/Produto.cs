using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private float precoVenda;
        private float precoCompra;
        private float quantidadeEstoque;
        private Fornecedor fornecedor;



        public void CadastraProduto(int codigo, string descricao, float precoVenda, float precoCompra, float quantidadeEstoque, Fornecedor fornecedor)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.precoVenda = precoVenda;
            this.precoCompra = precoCompra;
            this.quantidadeEstoque = quantidadeEstoque;
            this.fornecedor = fornecedor;
        }

        public string MostrarProduto(int valor)
        {

            String[] lista = { Convert.ToString(this.codigo), this.descricao, Convert.ToString(this.precoVenda),
                Convert.ToString(this.precoCompra), Convert.ToString(this.quantidadeEstoque), Convert.ToString(this.fornecedor)};

            string a = lista[valor];


            return a;


        }

        public void ListarProdutoeFornecedor()
        {
            Console.WriteLine();
            Console.WriteLine("DADOS DO PRODUTO");
            Console.WriteLine("CÓDIGO DO PRODUTO: {0} \nDESCRIÇÃO: {1} \nPREÇO DE VENDA \nPREÇO DE COMPRA: {2} \nQUANTIDADE EM ESTOQUE: {3}", Convert.ToString(this.MostrarProduto(0)), this.MostrarProduto(1), this.MostrarProduto(2), this.MostrarProduto(3), this.MostrarProduto(2));
            Console.WriteLine();
            Console.WriteLine("DADOS DO FORNECEDOR");
            Console.WriteLine("CÓDIGO DO FORNECEDOR: {0} \nRAZÃO SOCIAL: {1}", this.fornecedor.MostrarFornecedor(0), this.fornecedor.MostrarFornecedor(1));
            Console.WriteLine();
            Console.WriteLine("DADOS DE CONTATO DO FORNECEDOR");
            Console.WriteLine("CÓDIGO DE CONTATO: {0} \nNOME DE CONTATO: {1} \nEMAIL DE CONTATO: {2}", this.fornecedor.MostrarContatoFornecedor(0), this.fornecedor.MostrarContatoFornecedor(1), this.fornecedor.MostrarContatoFornecedor(2));

        }
        public void DeletaProduto()
        {
            this.codigo = 0;
            this.descricao = null;
            this.precoVenda = 0;
            this.precoCompra = 0;
            this.quantidadeEstoque = 0;
            this.fornecedor = null;

        }

    }


}    

