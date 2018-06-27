using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormAlumno.Contracts;

namespace WinFormAlumno.Utils {
    class FileManager : IFileManager {

        public void CreateJsonToFile(string path, string json) {
            try {
                File.WriteAllText(path, json);
            } catch (ArgumentException e) when (e.ParamName == "") {
                throw new Exception("Campos vacíos. No hay texto que guardar.");
            } catch (ArgumentException e) {
                throw new Exception("Algun parametro erroneo. PATH: "+path+" JSON: "+json);
            }
        }

        public string LoadJsonFile(string path) {
            try {
                return File.ReadAllText(path);
            }catch (FileNotFoundException e) {
                throw new Exception("No se encuentra el archivo");
            }
            
        }
    }
}
