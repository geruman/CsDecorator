using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsDecorator
{
    public abstract class AbstractPersonajeDecorator: Personaje
    {
        protected Personaje personajeDecorado;
        public AbstractPersonajeDecorator(Personaje unPersonaje)
        {
            personajeDecorado = unPersonaje;
        }

        public abstract int GetArmadura();
        public abstract string GetDescripcion();
    }
}
