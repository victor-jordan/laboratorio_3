using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_club.Modelos
{
    class clPelicula
    {
        int _pelicula_id;
        string _titulo;
        string _genero;
        string _año;
        string _director;
        string _formato;
        int _precio_alquiler;

        public int pelicula_id
        {
            get { return _pelicula_id; }
            set { _pelicula_id = value; }
        }

        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public string año
        {
            get { return _año; }
            set { _año = value; }
        }

        public string director
        {
            get { return _director; }
            set { _director = value; }
        }

        public string formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

        public int precio_alquiler
        {
            get { return _precio_alquiler; }
            set { _precio_alquiler = value; }
        }
    }
}
