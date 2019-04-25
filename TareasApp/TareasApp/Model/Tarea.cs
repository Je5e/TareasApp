using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TareasApp.Model
{
    [Table("Tareas")]
   public class Tarea // Clases Entidad del Modelo del Dominio.== Tabla
    {
        // Propiedades ? == Columnas de la tabla
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(100)]
        public string Nombre { get; set; }
        public string Notas { get; set; }
        public bool Estado { get; set; }

      
    }
}
