using System;
using System.Collections.Generic;
using System.Text;

namespace Zara.Reto0.Repository.Contracts
{
    public interface IFileManager{
        List<string[]> OpenCSV(string path);

    }
}
