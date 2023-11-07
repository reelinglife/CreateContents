using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CreateContents.View
{
    internal class MyView
    {
        const string mdFileName = "contents.md";
        public void CreateMarkDownFile(string dirPath, List<string> lines)
        {
            string mdFilePath = $"{dirPath}\\{mdFileName}";
            if (lines.Count > 0)
            {
                using (StreamWriter sw = new StreamWriter(mdFilePath, false, Encoding.UTF8))
                {
                    sw.WriteLine($"# Contents\r\n");
                    foreach (string line in lines)
                    {
                        sw.WriteLine($"[{line.Replace(".md", "")}]({line})\r\n");
                    }
                }
            }
        }
    }
}
