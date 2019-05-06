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

            BaseDeDatos.CreateTable<Tarea>();
        }

        // CRUD
        public int CrearTarea(Tarea nuevaTarea)
        {
            return BaseDeDatos.Insert(nuevaTarea);
        }

        public Tarea ObtenerTareaPorID(int id)
        {
            // select * from Tareas where ID == id
            return BaseDeDatos.Table<Tarea>().Where(t => t.ID == id).
                FirstOrDefault();
        }

        public List<Tarea> ObtenerTodasLasTareas()
        {
            return BaseDeDatos.Table<Tarea>().ToList();
        }

        public int ActualizarTarea(Tarea tareaAActualizar)
        {
            return BaseDeDatos.Update(tareaAActualizar);
            
        }
        public int EliminarTarea(Tarea tareaAEliminar)
        {
          return  BaseDeDatos.Delete(tareaAEliminar);
        }
    }
}
