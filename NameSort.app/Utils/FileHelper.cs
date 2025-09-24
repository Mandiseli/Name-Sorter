using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NameSort.App.Utils
{
    public static class FileHelper
    {
        public static IEnumerable<string> ReadNames(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File not found: {path}");

            return File.ReadAllLines(path)
                       .Where(line => !string.IsNullOrWhiteSpace(line)) // ignore empty lines
                       .Select(line => line.Trim()); // trim spaces
        }

        public static void WriteNames(string path, IEnumerable<string> names)
        {
            File.WriteAllLines(path, names);
        }
    }
}

