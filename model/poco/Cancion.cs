using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioProgramador.model.poco
{
    public class Cancion {

        private int idCancion;
        private string titulo;
        private string album;
        private string clave;
        private int prioridad;
        private bool activa;
        private string dias;
        private int idArtista;
        private int idGenero;
        private int idCategoria;

        public int IdCancion { get => idCancion; set => idCancion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Album { get => album; set => album = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }
        public bool Activa { get => activa; set => activa = value; }
        public string Dias { get => dias; set => dias = value; }
        public int IdArtista { get => idArtista; set => idArtista = value; }
        public int IdGenero { get => idGenero; set => idGenero = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
    }
}
