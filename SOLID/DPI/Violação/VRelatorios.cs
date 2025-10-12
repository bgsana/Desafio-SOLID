namespace SOLID.DPI.Violação;

public class VRelatorios
{
    public class RelatorioPDF
    {
        public void Gerar()
        {
            //Gera o relatório
        }
    }

    public class GeradorRelatorios
    {
        public RelatorioPDF relatorioPDF;

        public GeradorRelatorios()
        {
            relatorioPDF = new RelatorioPDF(); // Dependência direta
        }

        public void GerarRelatorio()
        {
            relatorioPDF.Gerar(); // Está preso à implementação PDF
        }
    }
}
