namespace SOLID.DPI.Solução;

public class SRelatorios
{
    public interface IRelatorio
    {
        void Gerar();
    }

    public class RelatorioPDF : IRelatorio
    {
        // Gera relatório PDF
    }
    public class RelatorioExcel : IRelatorio
    {
        // Gera relatório em excel
    }

    public class GeradorRelatorios
    {
        private IRelatorio _relatorio;

        public GeradorRelatorios(IRelatorio relatorio)
        {
            _relatorio = relatorio;
        }

        public void GerarRelatorio()
        {
            _relatorio.Gerar();
        }
    }
}
