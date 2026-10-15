using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Newtonsoft.Json;

namespace ExceptionTesting
{
    public class FileManager
    {
        private string path = "poznamky.json";
        private static FileManager instance = new FileManager();
        public static FileManager Instance => instance;

        private FileManager() { }

        public void SavePoznamky(List<Poznamka> poznamky)
        {
            // list -> text
            string pozn = JsonConvert.SerializeObject(poznamky);

            File.WriteAllText(path, pozn);
        }

        public List<Poznamka> LoadPoznamky()
        {
            if (!File.Exists(path))
                return new List<Poznamka>();

            string pozn = File.ReadAllText(path);
            var poznamky = JsonConvert.DeserializeObject<List<Poznamka>>(pozn);

            return poznamky;
        }

    }
}
