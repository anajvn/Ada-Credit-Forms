using AdaCredit.UI.Data;
using AdaCredit.UI.Domain;
using CsvHelper;
using System.Globalization;

namespace AdaCredit.UI.UseCases
{
    public class Download
    {
        public static void Execute(string[][] data, string name, string header)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(path, name);

            List<string> dataList = new List<string>();

            dataList.Add(header);
            for (int i = 0; i < data.Length; i++)
            {
                string content = "";
                for (int j = 0; j < data[i].Length; j++)
                {
                    content += data[i][j] + ", ";
                }
                content = content.Remove(content.Length - 2);
                dataList.Add(content);
            }

            File.WriteAllLines(filePath, dataList);
            
        }
    }
}
