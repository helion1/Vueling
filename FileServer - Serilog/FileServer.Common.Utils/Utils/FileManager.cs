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

        public static bool FileExists(String path) {
            return File.Exists(path);
        }


        public void CreateJsonToFile(string path, string json) {
            if (path == null || json == null) throw new ArgumentNullException();
            try {
                File.WriteAllText(path, json);
            } catch (ArgumentNullException e) {
                throw e;
            } catch (PathTooLongException e) {
                throw e;
            } catch (DirectoryNotFoundException e) {
                throw e;
            } catch (IOException e) {
                throw e;
            } catch (UnauthorizedAccessException e) {
                throw e;
            } catch (NotSupportedException e) {
                throw e;
            } catch (SecurityException e) {
                throw e;
            }
        }

        public string LoadJsonFile(string path) {
            try {
                return File.ReadAllText(path);
            } catch (ArgumentNullException e) {
                throw e;
            } catch (PathTooLongException e) {
                throw e;
            } catch (DirectoryNotFoundException e) {
                throw e;
            } catch (IOException e) {
                throw e;
            } catch (UnauthorizedAccessException e) {
                throw e;
            } catch (NotSupportedException e) {
                throw e;
            } catch (SecurityException e) {
                throw e;
            }

        }
    }
}
