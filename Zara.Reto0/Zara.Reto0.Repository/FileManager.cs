using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Zara.Reto0.Repository.Contracts;

namespace Zara.Reto0.Repository
{
    class FileManager : IFileManager {
        public List<string[]> OpenCSV(string path) {
            List<string[]> parsedData = new List<string[]>();

            using(StreamReader readFile = new StreamReader(path)) {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null) {
                    row = line.Split('\n');
                    parsedData.Add(row);
                }
            }
            return parsedData;
        }

    }
}
