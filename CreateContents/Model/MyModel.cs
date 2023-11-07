using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CreateContents.Model
{
    internal class MyModel
    {
        const string yamlFileName = "toc.yml";
        private List<string> _lines = new List<string>();
        private string _dirPath;
        public MyModel(string[] args)
        {
            SetDirPath(args);
        }
        private void SetDirPath(string[] args)
        {
            if (args.Length == 1)
            {
                _dirPath = args[0];
            }
        }
        public List<string> Lines => _lines;
        
        public string DirPath => _dirPath;
        
        public void CreateLines()
        {
            List<string> lines = new List<string>();
            string yamlPath = $"{_dirPath}\\{yamlFileName}";
            if (File.Exists(yamlPath))
            {
                using (StreamReader sr = new StreamReader(yamlPath, Encoding.UTF8))
                {
                    while (sr.Peek() > 0)
                    {
                        string line = sr.ReadLine();
                        if (line.IndexOf("  href:") == 0)
                        {
                            string[] strAry = line.Split(' ');
                            lines.Add(strAry[strAry.Length - 1]);
                        }
                    }
                }
            }
            _lines = lines;
        }
    }
}
