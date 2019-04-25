using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TareasApp.Helper
{
   public class HelperDB
    {
        public static string GetFilePath() // Método
        {
            return Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData)
                    , "TareasDB.db");
            // HelperDB.GetFilePath() -- NO=> new = HelperDB();
        }
    }
}
