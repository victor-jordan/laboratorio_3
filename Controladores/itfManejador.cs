using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Collections.Generic;


namespace video_club.Controladores
{
    interface itfManejador<T>
    {
        DataTable ObtenerTodos();
        string ObtenerUno(String key);
        string[] Colecciones(String campo);
        string Insertar(T obj);
        void Modificar(T obj);
        void Borrar(Int32 key);
    }
}
