using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public abstract class ProdutoBase
    {
        public long Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
    }
}
