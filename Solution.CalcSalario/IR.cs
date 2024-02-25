using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.CalcSalario
{
    public class IrTable
    {
        public double MenorBaseDeCalculo { get; set; }
        public double MaiorBaseDeCalculo { get; set; }
        public double Aliquota { get; set; }
        public double ParcelaADeduzirDoIR { get; set; }
    }
}
