namespace CsDecorator
{
    public class ChalecoDecorator : AbstractPersonajeDecorator
    {
        public ChalecoDecorator(Personaje unPersonaje):base(unPersonaje)
        {

        }
        public override int GetArmadura()
        {
            return personajeDecorado.GetArmadura() + 4;
        }

        public override string GetDescripcion()
        {
            return "bajo un hermoso chaleco hay " + personajeDecorado.GetDescripcion();
        }
    }
}
