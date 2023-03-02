using System.IO;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        var output = new SortedDictionary<int, List<string>>();
        string s;
        while(( s = Console.ReadLine()) != null)
        {
            string file = Console.ReadLine();
            int depth;
            depth = file.Count(c => c == '/');
            if (!file.EndsWith('/'))
            { 
                depth++;
            }
            if (output.ContainsKey(depth) == false)
            {
                output[depth] = new List<string>();
            }
            output[depth].Add(file);
        }
        foreach (var lines in output)
        {
            foreach (var line in lines.Value)
            {
                Console.WriteLine(line);
            }

        }

    }
}
