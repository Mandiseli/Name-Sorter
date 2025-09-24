using NameSort.App.Services;
using NameSort.App.Utils;

class Program
{
    static void Main(string[] args)
    {
        var inputPath = args.Length > 0 ? args[0] : "unsorted-names-list.txt";
        var outputPath = "sorted-names-list.txt";

        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Error: File not found: {inputPath}");
                return;
            }

            var unsortedNames = FileHelper.ReadNames(inputPath);

            var sorter = new NameSorterService();
            var sortedNames = sorter.SortNames(unsortedNames);

            foreach (var name in sortedNames)
                Console.WriteLine(name);

            FileHelper.WriteNames(outputPath, sortedNames.Select(n => n.ToString()));

            Console.WriteLine($"\nSorted names written to {outputPath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
