using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using AbstractFactory.Classes;
using AbstractFactory.Factory;

namespace AbstractFactory
{
    public class CriacaoProduto
    {
        ProdutoFactory _fabrica = null;
        public CriacaoProduto(Int64 codigoInformado)
        {
            switch (codigoInformado)
            {
                case 1:
                    _fabrica = new ProdutoMarteloFactory();
                    break;
                case 2:
                    _fabrica = new ProdutoMarretaFactory();
                    break;
                default:
                    _fabrica = null;
                    break;
            }
        }

        public ProdutoBase ObterProduto()
        {
            if (_fabrica != null)
                return _fabrica.CriarProduto();
            else
                return null;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            Int32  _codigoProdutoInformado = 1;
            string _mensagem = "";

            ProdutoBase produto = new CriacaoProduto(_codigoProdutoInformado).ObterProduto();

            if (produto != null)
                Console.WriteLine("Você criou o produto " + produto.Descricao);
            else
                Console.WriteLine("Não existe um produto com este código");

            Console.WriteLine(_mensagem);
            Console.ReadKey();
        }
    }
}
