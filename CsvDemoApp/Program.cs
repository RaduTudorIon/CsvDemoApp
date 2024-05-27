using CsvHelper;
using System.Globalization;

namespace CsvDemoApp;

internal class Program
{
    static void Main(string[] args)
    {
        string inputFile = @"";
        string outputFile = @"";

        List<CustomerModel> outputRecords = new();
        using var reader = new StreamReader(inputFile);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    }
}