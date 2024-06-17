using System.Data;

namespace SOLID.OpenClosedPrinciple;

/// <summary>
/// Now, by creating abstract class and inherite file exporting different types from this file exporter abstract class,we abay from open close principle.
/// </summary>
public class BasedOnPrinciple
{
    public abstract class FileExporter
    {
        public abstract void Export(string filePath, DataTable data);
    }
    public class CsvFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to a CSV file.
        }
    }
    public class ExcelFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to an Excel file.
        }
    }
    public class JsonFileExporter : FileExporter
    {
        public override void Export(string filePath, DataTable data)
        {
            // Code logic to export data to a JSON file.
        }
    }

}