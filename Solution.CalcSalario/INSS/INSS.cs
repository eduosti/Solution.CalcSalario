using Newtonsoft.Json;
using System.Collections.Generic;
public class InssDados
{
    public double MinSalary { get; set; }
    public double MaxSalary { get; set; }
    public double Percentage { get; set; }
    public double FixedValue { get; set; }

    public static List<InssDados> LoadInssTable()
    {
        // Load the INSS table from a file, database, or other storage
        // For example, using a JSON file:
        string json = File.ReadAllText("INSS/inssTable.json");
        List<InssDados> inssTables = JsonConvert.DeserializeObject<List<InssDados>>(json);

        // Return the INSS table
        return inssTables;
    }

    public static void SaveInssTable(List<InssDados> inssTables)
    {
        string json = JsonConvert.SerializeObject(inssTables, Formatting.Indented);
        File.WriteAllText("INSS/inssTable.json", json);
    }
}

   


