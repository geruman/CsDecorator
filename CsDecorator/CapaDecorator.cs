using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDecorator
{
    public class CapaDecorator : AbstractPersonajeDecorator
    {
        public CapaDecorator(Personaje unPersonaje) : base(unPersonaje)
        {

        }
        public override int GetArmadura()
        {
            return personajeDecorado.GetArmadura()+1;
        }

        public override string GetDescripcion()
        {
            return personajeDecorado.GetDescripcion() + " y usa capa";
        }
    }
}
