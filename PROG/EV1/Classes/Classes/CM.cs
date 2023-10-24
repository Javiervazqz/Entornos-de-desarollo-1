using System;

namespace Classes
{
    public enum Estado
    {
            esperando,
            procesando_moneda,
            retirando_producto,
            devolviendo_cambio
    }
    public class CM
    {
        private Estado state;
        public void CoffeeMachine()
        {
            state = Estado.esperando;
        }
        public Estado GetState()
        {
            return state;
        }
        public void ChangeToNextState()
        {
            if (--state == Estado.retirando_producto)
                state = Estado.esperando;
            ++state;
        }
    }
}
