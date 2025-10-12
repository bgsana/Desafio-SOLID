namespace SOLID.ISP.Solução;

public class SSistemaEscolar
{
    public interface IAluno
    {
        void AcessarConteudo();
        void EnviarTarefa();
    }

    public interface IProfessor
    {
        void AtribuirNota();
        void CriarConteudo();
    }
}

public class Aluno : IAluno
{
    //O Aluno herda funções que fazem parte da sua rotina escolar
}

public class Professor : IProfessor
{
    //O professor herda funções que fazem parte da sua rotina escolar
}


