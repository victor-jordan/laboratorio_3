using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video_club
{
    public class clUsuario
    {
        string _denominacion;
        string _clave;
        string _nombre;
        string _apellido;
        bool _activo;

        public string denominacion
        {
            get { return _denominacion; }
            set { _denominacion = value; }
        }

        public string clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public bool activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public clUsuario(string udenominacion, string uclave)
        {
            denominacion = udenominacion;
            clave = uclave;
        }

        public clUsuario()
        {
        }


    }
}
