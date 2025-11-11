using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScapeRoomCFP
{
    internal class WordIO
    {

        //Sigue la estructura del interface
        public string Nombre => "Adivine la palabra";
        public bool EstaResuelto { get; private set; } = false;


        public void Resolver()
        {
            EstaResuelto = true;
        }
        //

        private string passwordCorrecta = "conexion";


        public bool Validar(string input)
        {
            if (input == passwordCorrecta)
            {
                Resolver();
                return true;
            }
            return false;
        }
        public string ObtenerPalabraCorrecta()
        {
            return passwordCorrecta;
        }


    }
}
