using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScapeRoomCFP
{
    internal class ContraseñaPuzle : IPuzzle
    {

        //Sigue la estructura del interface
        public string Nombre => "Puzle de Contarseña";
        public bool EstaResuelto { get; private set; } = false;

        public void Resolver()
        {
            EstaResuelto = true;
        }
        //

        private string passwordCorrecta = "ewe";

        public bool Validar(string input)
        {
            if (input == passwordCorrecta)
            {
                Resolver();
                return true;
            }
            return false;
        }



    }
}
