using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DEPENDENTE
{
    public class DependenteDados
    {
        public double ValorDependente { get; set; }

        public static List<DependenteDados> LoadDependenteTable()
        {
            // Load the INSS table from a file, database, or other storage
            // For example, using a JSON file:
            string json = File.ReadAllText("Dependente/DependenteTable.json");
            List<DependenteDados> dependenteTables = JsonConvert.DeserializeObject<List<DependenteDados>>(json);

            // Return the INSS table
            return dependenteTables;
        }



        public static void SaveDependenteTable(List<DependenteDados> dependenteTables)
        {
            string json = JsonConvert.SerializeObject(dependenteTables, Formatting.Indented);
            File.WriteAllText("Dependente/DependenteTable.json", json);
        }
    }
}
