using System.Text;

namespace asycnawaitTest
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string filename = @"D:\tmp\a.txt";
            StringBuilder sb  = new StringBuilder();
            for(int i = 0; i < 10000; i++)
            {
                sb.AppendLine("hello");
            }
            await File.WriteAllTextAsync(filename, sb.ToString());
            string s =  await File.ReadAllTextAsync(filename);
            Console.WriteLine(s);
        }
    }
}
