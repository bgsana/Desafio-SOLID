namespace SOLID.OCP.Violação;

public class VDesconto
{
    public double CalcularDesconto (string tipo, double valor)
    {
        if (tipo == "Normal")
            return (valor * 0.2) - valor;
        else if (tipo == "Especial")
            return (valor * 0.5) - valor;
        else
            return valor;
    }
}
