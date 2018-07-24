using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Empresa
    {
        private static Empresa instance;

        private Empresa() { }

        public static Empresa Instance
        {
            get
            {
                if (instance == null)
                    instance = new Empresa();
                return instance;
            }
        }
    }
}
