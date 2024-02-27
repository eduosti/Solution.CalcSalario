using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using INSS;
using IR;
using DEPENDENTE;

internal class CalculoSalLiquido
    {

    public class SalarioLiquidoResult
    {
        public double ValorTotalDependente { get; set; }
        public double DeducaoInss { get; set; }
        public double DeducaoIr { get; set; }
        public double SalarioLiquido { get; set; }
    }



    public static SalarioLiquidoResult CalculateSalarioLiquido(int varQtdDep, double varSalario, double varValorDesc)
    {          
         List<InssDados> inssTables = InssDados.LoadInssTable();

        List<ValorLimiteINSS> ValorLimiteInssList = ValorLimiteINSS.LoadInssValorLimite();

        List<IRDados> IrTables = IRDados.LoadTableIR();            

         List<DependenteDados> DependenteTables = DependenteDados.LoadDependenteTable();
         

         double DeducaoInss = 0;

         foreach (var inssTable in inssTables)
         {
            if (varSalario >= inssTable.MinSalary && inssTable.MaxSalary == 0 || varSalario >= inssTable.MinSalary && varSalario <= inssTable.MaxSalary)
            {
                DeducaoInss += Math.Round(((varSalario * inssTable.Percentage) / 100) - inssTable.FixedValue, 2);
            }            
         }

        foreach (var inssValorLimite in ValorLimiteInssList)
        {
            if (DeducaoInss >= inssValorLimite.ValorLimiteInssDados)
            {
                DeducaoInss = inssValorLimite.ValorLimiteInssDados;
            }
        }

                double DeducaoIr = 0;         
         double ValorTotalDependente = 0;
         
         foreach (var DepTable in DependenteTables)
         {
             ValorTotalDependente = varQtdDep * DepTable.ValorDependente;
         }

         double SalarioBase = varSalario - DeducaoInss - ValorTotalDependente;

         foreach (var irTable in IrTables)
         {
            if (SalarioBase >= irTable.MenorBaseDeCalculo && irTable.MaiorBaseDeCalculo == 0 || SalarioBase >= irTable.MenorBaseDeCalculo && SalarioBase <= irTable.MaiorBaseDeCalculo)
            {
                DeducaoIr = Math.Round(((SalarioBase * irTable.Aliquota) / 100) - irTable.ParcelaADeduzirDoIR, 2);
            }
         }

         double salarioLiquido = Math.Round(varSalario - DeducaoInss - DeducaoIr - varValorDesc, 2);

         return new SalarioLiquidoResult
         {
             ValorTotalDependente = ValorTotalDependente,
             DeducaoInss = DeducaoInss,
             DeducaoIr = DeducaoIr,
             SalarioLiquido = salarioLiquido
         };
    }
}

