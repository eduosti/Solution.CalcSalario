using Newtonsoft.Json;
using System.Collections.Generic;

namespace INSS
{
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

    public class ValorLimiteINSS
    {
        public double ValorLimiteInssDados { get; set; }
        public static List<ValorLimiteINSS> LoadInssValorLimite()
        {
            // Load the INSS table from a file, database, or other storage
            // For example, using a JSON file:
            string jsonValorLimi = File.ReadAllText("INSS/ValorLimiteINSS.json");
            List<ValorLimiteINSS> ValorLimiteInssList = JsonConvert.DeserializeObject<List<ValorLimiteINSS>>(jsonValorLimi);

            // Return the INSS table
            return ValorLimiteInssList;
        }
        public static void SaveValorMaxInss(List<ValorLimiteINSS> ValorLimiteINSSJson)
        {
            string jsonValorLimi = JsonConvert.SerializeObject(ValorLimiteINSSJson, Formatting.Indented);
            File.WriteAllText("INSS/ValorLimiteINSS.json", jsonValorLimi);
        }
    }
}
