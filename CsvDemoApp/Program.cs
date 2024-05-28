using CsvHelper;
using System.Globalization;

namespace CsvDemoApp;

internal class Program
{
    static void Main(string[] args)
    {
        string inputFile = @"C:\Users\radut\source\repos\CsvDemoApp\CsvDemoApp\people-100.csv";
        string outputFile = @"C:\Users\radut\source\repos\CsvDemoApp\CsvDemoApp\filtered-people.csv";

        var outputRecords = new List<CustomerModel>();
        using var reader = new StreamReader(inputFile);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        var records = csv.GetRecords<CustomerModel>();

        foreach (var record in records)
        {
            Console.WriteLine(record.FirstName + " " + record.LastName + " " + record.DateOfBirth.ToShortDateString() + " " + record.JobTitle);
            if (record.DateOfBirth.Year < 1980)
            {
                outputRecords.Add(record);
            }
        }

        Console.WriteLine($"Number of records:{ outputRecords.ToList().Count }");

        using var writer = new StreamWriter(outputFile);
        using var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csvWriter.WriteRecords(outputRecords);
        csvWriter.Flush();
    }
}