using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Classes;

namespace AbstractFactory
{
    public abstract class ProdutoFactory
    {
        public abstract ProdutoBase CriarProduto();
    }
}
