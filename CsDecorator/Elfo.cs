using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDecorator
{
    public class Elfo: Personaje
    {
        public string GetDescripcion()
        {
            return "Un elfo";
        }

        public int GetArmadura()
        {
            return 0;
        }

    }
}
