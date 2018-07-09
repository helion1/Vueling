using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Zara.Reto0.Utils
{
    public class FileManager{
        public static List<string> OpenCSV(string path) {
            List<string> parsedData = new List<string>();

            using(StreamReader readFile = new StreamReader(path)) {
                string line;
                string[] row;

                while ((line = readFile.ReadLine()) != null) {
                    row = line.Split('\n');
                    parsedData.Add(row[0]);
                }
            }
            return parsedData;
        }

    }
}
