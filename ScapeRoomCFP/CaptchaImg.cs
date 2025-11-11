using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScapeRoomCFP {
    internal class CaptchaImg : IPuzzle {

        //Sigue la estructura del interface
        public string Nombre => "Captcha Imagenes";
        public bool EstaResuelto { get; private set; } = false;

        public void Resolver() {
            EstaResuelto = true;
        }        

    }
}
