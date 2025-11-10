using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScapeRoomCFP
{
    public interface IPuzzle
    {
        string Nombre { get; }
        bool EstaResuelto { get; }
        void Resolver();
    }
    public class GameManager
    {
        //ClaveFinal
        public int ClaveFinal = 0000;
        //PuzlesResueltos (Formatolista)
        public List<IPuzzle> PuzlesResueltos { get; } = new List<IPuzzle>();
        //TiempoRestante (igual esto es solo para intentar morstrar algo en pantalla, creo que puedo controlar el flujo del juego desde el timer dentro del form)
        public int TiempoRestante = 0; //Puedo recibir el tiempo del timer colocado en el form o tendria que setear un timer acá tambien?
        //Progreso (Supongo que se calcula segun la cantidad de puzles resueltos añadidos a la lista)
        public bool TodosResueltos = false;


        //FinalAlcanzado


    }
}
