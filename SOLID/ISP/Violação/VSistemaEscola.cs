namespace SOLID.ISP.Violação;

public interface VSistemaEscola
{
    void AcessarConteudo();
    void EnviarTarefa();
    void AtribuirNota();
    void CriarConteudo();
}

public class Aluno : ISistemaEscola
{
    //O aluno vai herdar funções que não fazem parte de sua rotina
}

public class Professor : ISistemaEscola
{
    //O professor vai herdar funções que não fazem parte de sua rotina
}
