using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScapeRoomCFP
{
    public class ChatManager
    {
        private GameManager game;

        public ChatManager(GameManager gm)
        {
            game = gm;
        }

        public string RecibirPrimerMensaje()
        {
            return "Hola, me recibe alguien?---";
        }

        public string RecibirMensajeProgreso() //Se añaden mensajes al chat segun la cantidad de puzzles resueltos en la lista
        {
            int resueltos = game.PuzlesResueltos.Count(p => p.EstaResuelto);
            switch (resueltos)
            {
                case 0:
                    return "Prueba buscar en el correo del administrador. Creo que dejo una clave por ahi y con eso deberias poder ingresar a la galeria";
                case 1:
                    return "Bien hecho. Fijate ahora en la galería, hay algo que deberias ver.";
                case 2:
                    return "pista 2";
                case 3:
                    return "pista 3";
                case 4:
                    return "Solo queda obtener la contraseña final. Tenés que darte prisa.";
                case 5:
                    return "Ahora desbloquea la calculadora. Ingresa la contraseña y eso deberia ser todo.";
                default:
                    return "Error";
            }

            
        }
    }
}
