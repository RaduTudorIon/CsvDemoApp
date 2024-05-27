using CsvHelper;
using System.Globalization;

namespace CsvDemoApp;

internal class Program
{
    static void Main(string[] args)
    {
        string inputFile = @"C:\Users\radut\source\repos\CsvDemoApp\CsvDemoApp";
        string outputFile = @"C:\Users\radut\source\repos\CsvDemoApp\CsvDemoApp";

        List<CustomerModel> outputRecords = new();
        using var reader = new StreamReader(inputFile);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    }
}