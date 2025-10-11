namespace SOLID.OCP.Solução;

public class SDesconto
{
    public double CalcularDesconto(string tipo, double valor)
    {
        return valor - (valor * 0.2);
    }
}
public class DescontoEspecial : CalcularDesconto
{
    public override double CalcularDesconto(string tipo, double valor)
    {
        return valor - (valor * 0.5);
    }
}


