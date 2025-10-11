namespace SOLID.LSP.Solução;

public class SVeiculo
{
    public class Veiculo
    {
        public virtual void Mover()
        {
            //O veículo se move
        }
    }

    public class VeiculoMotorizado : Veiculo
    {
        public virtual void Abastecer()
        {
            //O veículo pode ser abastecido
        }
    }

    public class Carro : VeiculoMotorizado
    {
        //O carro consegue fazer todas as funcionalidades descritas em sua herança
    }
    
    public class Bicicleta : Veiculo
    {
        //A bicicleta consegue fazer todas as funcionalidades descritas em sua herança
    }
}
