using System.Data;

namespace SOLID.OpenClosedPrinciple;

/// <summary>
/// File exporter is violating open close principle.
/// Why?
/// let me explain.
/// when we want to add exporting for another type of file we have to modify file exporter which violate open close principle.
/// </summary>
public class ViolatePrinciple
{
    public class FileExporterViolatePrinciple
    {
        public void ExportToCsv(string filePath, DataTable data)
        {
            // Code to export data to a CSV file.
        }
    }
}
