using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes.Produtos
{
    public class Marreta : ProdutoBase
    {
        public Marreta()
        {
            base.Codigo = 2;
            base.Descricao = "Marreta";
            base.Preco = 50;
        }
    }
}
