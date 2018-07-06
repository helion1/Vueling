using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAlumno.Contracts;
using System.Security;

namespace WinFormAlumno.Utils {
    public class FileManager : IFileManager {

        public void CreateJsonToFile(string path, string json) {
            if (path == null || json == null) throw new ArgumentNullException();
            try {
                File.WriteAllText(path, json);
            } catch (ArgumentException) {
                throw new Exception("Campos vacíos. No hay texto que guardar.");
            } catch (SecurityException) {
                throw new Exception("Faltan permisos para crear archivos");
            }
        }

        public string LoadJsonFile(string path) {
            if (path == null) throw new ArgumentNullException();
            try {
                return File.ReadAllText(path);
            }catch (FileLoadException) {
                throw new Exception("No se encuentra el archivo");
            }
            
        }
    }
}
