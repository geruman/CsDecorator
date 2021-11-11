using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDecorator
{
    public class Hobbit : Personaje
    {
        public int GetArmadura()
        {
            return 0;
        }

        public string GetDescripcion()
        {
            return "Un hobbit";
        }
    }
}
