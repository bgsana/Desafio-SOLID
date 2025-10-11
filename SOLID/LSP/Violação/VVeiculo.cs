namespace SOLID.LSP.Violação;

public class VVeiculo
{
    public class Veiculo
    {
        public virtual void Abastecer()
        {
            //O veículo pode ser abastecido
        }
        public virtual void Dirigir()
        {
            //O veículo é dirigido
        }
    }

    public class Carro : Veiculo
    {

    }
    public class Moto : Veiculo
    {

    }

    public class Bicicleta : Veiculo
    {
        public override void Dirigir()
        {
            //A bicicleta é pedalada
        }
        public override void Abastecer()
        {
            //A bicicleta não é abastecida
        }
    }
}
