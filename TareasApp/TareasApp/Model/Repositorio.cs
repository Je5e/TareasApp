using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TareasApp.Model
{
   public class Repositorio
    {
        // Un constructor, Connection,  métodos del CRUD
        SQLiteConnection BaseDeDatos;

        public Repositorio()
        {
            // FilePath
            string DBFilePath =
                Helper.HelperDB.GetFilePath();

            // Instanciar la clase SQLiteConnection
            BaseDeDatos = new SQLiteConnection(DBFilePath);
        }
    }
}
