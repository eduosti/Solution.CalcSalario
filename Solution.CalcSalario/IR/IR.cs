using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IR
{
    public class IRDados
    {
        public double MenorBaseDeCalculo { get; set; }
        public double MaiorBaseDeCalculo { get; set; }
        public double Aliquota { get; set; }
        public double ParcelaADeduzirDoIR { get; set; }

        public static List<IRDados> LoadTableIR()
        {
            // Load the INSS table from a file, database, or other storage
            // For example, using a JSON file:
            string json = File.ReadAllText("IR/IRTable.json");
            List<IRDados> IrTables = JsonConvert.DeserializeObject<List<IRDados>>(json);

            // Return the INSS table
            return IrTables;
        }

        public static void SaveIrTable(List<IRDados> IrTables)
        {
            string json = JsonConvert.SerializeObject(IrTables, Formatting.Indented);
            File.WriteAllText("IR/IRTable.json", json);
        }
    }
}
