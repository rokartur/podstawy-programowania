using System.Text;

class Program
{
    private static void Main()
    {
        const string filePath = "biodata.txt";
        const string content = "Sekwencja kwasów nukleinowych: 5-AATTGGCC-3";

        File.WriteAllText(filePath, content);

        using (var fs = new FileStream(filePath, FileMode.Open))
        {
            fs.Seek(32, SeekOrigin.Begin);

            using (var sr = new StreamReader(fs, Encoding.UTF8))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        File.Delete(filePath);
        Console.Clear();
    }
}
