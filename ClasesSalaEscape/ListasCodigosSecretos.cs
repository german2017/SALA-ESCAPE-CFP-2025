namespace ClasesSalaEscape
{
    public class ListasCodigosSecretos
    {
        // Clase para representar cada lista con sus opciones
        public class ListaConOpciones
        {
            public List<string> Elementos { get; set; }
            public string OpcionCorrecta { get; set; }
            public List<string> OpcionesIncorrectas { get; set; }
        }

        // Definir tus listas con opciones
        public static ListaConOpciones ListaAmerica = new ListaConOpciones
        {
            Elementos = new List<string> { "Argentina", "Puerto Rico", "México", "Haiti" },
            OpcionCorrecta = "De América",
            OpcionesIncorrectas = new List<string> { "Hispanohablantes", "Del Hemisferio Norte" },
        };

        public static ListaConOpciones ListaMamiferos = new ListaConOpciones
        {
            Elementos = new List<string> { "Murciélago", "Delfin", "Elefante", "Canguro" },
            OpcionCorrecta = "Son mamíferos",
            OpcionesIncorrectas = new List<string> { "Expectativa máxima de vida de 40 años", "Comen carne" },
        };

        public static ListaConOpciones ListaAves = new ListaConOpciones
        {
            Elementos = new List<string> { "Águila", "Colibrí", "Pingüino", "Búho" },
            OpcionCorrecta = "Aves",
            OpcionesIncorrectas = new List<string> { "Animales voladores", "Carnivoros extrictos" },
        };

        public static ListaConOpciones ListaElementosQuimicos = new ListaConOpciones
        {
            Elementos = new List<string> { "Oxígeno", "Carbono", "Hierro", "Oro" },
            OpcionCorrecta = "Elementos químicos",
            OpcionesIncorrectas = new List<string> { "Compuestos quimicos", "Elementos de Minecraft" },
        };

        public static ListaConOpciones ListaAmarillo = new ListaConOpciones
        {
            Elementos = new List<string> { "Limón", "Oro", "Girasol", "Azufre" },
            OpcionCorrecta = "Cosas amarillas",
            OpcionesIncorrectas = new List<string> { "Cosas tóxicas", "Cosas verdes" },
        };

        public static ListaConOpciones ListaRojo = new ListaConOpciones
        {
            Elementos = new List<string> { "Fresa", "Sangre", "Rubí", "Amapola" },
            OpcionCorrecta = "Cosas rojas",
            OpcionesIncorrectas = new List<string> { "Cosas rosadas", "Cosas muy oscuras" },
        };

        public static ListaConOpciones ListaAsia = new ListaConOpciones
        {
            Elementos = new List<string> { "Japón", "India", "Arabia Saudita", "Rusia" },
            OpcionCorrecta = "De Asia",
            OpcionesIncorrectas = new List<string> { "Religión oficial budista", "Tienen más de un millon km² de superficie" },
        };

        public static ListaConOpciones ListaEquipos = new ListaConOpciones
        {
            Elementos = new List<string> { "Barcelona", "Celtic", "Manchester", "River" },
            OpcionCorrecta = "Equipos de fútbol",
            OpcionesIncorrectas = new List<string> { "Ciudades de Europa", "Apellidos de origen ingles" },
        };

        public static ListaConOpciones ListaEscolar = new ListaConOpciones
        {
            Elementos = new List<string> { "Lápiz", "Hoja", "Regla", "Tijera" },
            OpcionCorrecta = "Utiles Escolares",
            OpcionesIncorrectas = new List<string> { "Herramientas", "Juguetes" },
        };

        public static ListaConOpciones ListaPrimos = new ListaConOpciones
        {
            Elementos = new List<string> { "2", "7", "13", "19" },
            OpcionCorrecta = "Números Primos",
            OpcionesIncorrectas = new List<string> { "Números Impares", "Números Compuestos" },
        };


        // Lista de todas las listas disponibles
        private static List<ListaConOpciones> TodasLasListas = new List<ListaConOpciones>
        {
            ListaAmerica,
            ListaMamiferos,
            ListaAves,
            ListaElementosQuimicos,
            ListaAmarillo,
            ListaRojo,
            ListaAsia,
            ListaEquipos,
            ListaEscolar,
            ListaPrimos
        };

        private static Random random = new Random();

        // Método para obtener una lista aleatoria
        public static ListaConOpciones ObtenerListaAleatoria()
        {
            int indice = random.Next(TodasLasListas.Count);
            return TodasLasListas[indice];
        }

        // Método para obtener las opciones correctas y las incorrectas mezcladas
        public static List<string> ObtenerOpcionesMezcladas(ListaConOpciones lista)
        {
            List<string> todasOpciones = new List<string>
            {
                lista.OpcionCorrecta
            };
            todasOpciones.AddRange(lista.OpcionesIncorrectas);

            return MezclarLista(todasOpciones);
        }

        private static List<string> MezclarLista(List<string> lista)
        {
            List<string> listaMezclada = new List<string>(lista);
            Random random = new Random();

            for (int i = listaMezclada.Count - 1; i > 0; i--)
            {
                int indiceAleatorio = random.Next(i + 1);
                // Intercambiar elementos
                string temp = listaMezclada[i];
                listaMezclada[i] = listaMezclada[indiceAleatorio];
                listaMezclada[indiceAleatorio] = temp;
            }

            return listaMezclada;
        }
    }
}
