using OfficeOpenXml;

namespace SalvaDados
{
    public class SalvaDados
    {
        public static void SalvaParaExcel(double salario, double totalDependente, double valorTotalDependente, double DeducaoInss, double DeducaoIr, double varValorDesc, double salarioLiquido, string caminho_salvar_arquivo)
        {
            ExcelPackage.LicenseContext = LicenseContext.Commercial; // or LicenseContext.NonCommercial

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Resultado");

                worksheet.Cells[1, 1].Value = "Salário";
                worksheet.Cells[1, 2].Value = "Total Dependente";
                worksheet.Cells[1, 3].Value = "Valor Total Dependente";
                worksheet.Cells[1, 4].Value = "Dedução INSS";
                worksheet.Cells[1, 5].Value = "Dedução IR";
                worksheet.Cells[1, 6].Value = "Valor do Desconto";
                worksheet.Cells[1, 7].Value = "Salário Líquido";

                worksheet.Cells[2, 1].Value = salario;
                worksheet.Cells[2, 2].Value = totalDependente;
                worksheet.Cells[2, 3].Value = valorTotalDependente;
                worksheet.Cells[2, 4].Value = DeducaoInss;
                worksheet.Cells[2, 5].Value = DeducaoIr;
                worksheet.Cells[2, 6].Value = varValorDesc;
                worksheet.Cells[2, 7].Value = salarioLiquido;

                package.SaveAs(caminho_salvar_arquivo);
            }

        }
    }
}