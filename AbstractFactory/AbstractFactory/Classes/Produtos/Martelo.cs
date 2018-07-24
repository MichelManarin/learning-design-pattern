using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Produtos
{
    public class Martelo : ProdutoBase
    {
        public Martelo()
        {
            base.Codigo = 1;
            base.Descricao = "Martelo";
            base.Preco = 20.5;
        }
    }
}
