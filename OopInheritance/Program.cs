namespace OopInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File f = new File("Fisier1", "txt");
            f.Open();

            ExcelFile excelFile = new ExcelFile("Workbook", "2023");
            excelFile.Open();
            excelFile.PerformCalculation("a = b + c");

            PdfFile pdfFile = new PdfFile("Declaratie", true);
            pdfFile.Open();
            pdfFile.AttemptEdit();

            File f2 = excelFile;
            f2.Open();
        }
    }
}