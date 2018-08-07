using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using VuelingExamen.Infrastructure.Repository.Contracts;

namespace VuelingExamen.Infrastructure.Repository.Utils {
    public static class FileManager {

        public static bool FileExists(String path) {
            return File.Exists(path);
        }


        public static void CreateJsonToFile(string path, string json) {
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

        public static string LoadJsonFile(string path) {
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
