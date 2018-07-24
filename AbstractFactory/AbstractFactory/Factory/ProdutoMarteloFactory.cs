using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Classes.Produtos;
using AbstractFactory.Classes;

namespace AbstractFactory.Factory
{
    public class ProdutoMarteloFactory : ProdutoFactory
    {
        public override ProdutoBase CriarProduto()
        {
            return new Martelo();
        }
    }
}
