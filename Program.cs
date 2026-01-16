CarroEletrico meuCarroEletrico = new CarroEletrico();
meuCarroEletrico.Modelo = "Tesla 3";
meuCarroEletrico.Abastcer(10);
meuCarroEletrico.RealizarRevisao();
Console.WriteLine($"Veículo: {meuCarroEletrico.Modelo} está pronto para uso!");

Caminhao meuCaminhao = new Caminhao();
meuCaminhao.Modelo = "Caminhão Honda";
meuCaminhao.Abastcer(100);
meuCaminhao.RealizarRevisao();
Console.WriteLine($"Veículo: {meuCaminhao.Modelo} está pronto para uso!");

public abstract class Veiculo{

    protected string Placa{get; set;}
    public string Modelo{get; set;}

    public abstract void Abastcer(double litros);
}

public interface IManutencao
{
    void RealizarRevisao();
}

public class Caminhao : Veiculo, IManutencao{
    public double CargaMaxima{get; set;}

    public override void Abastecer(double litros){
        Console.WriteLine($"Abastecendo Caminhão com {litros} litros de Diesel. Custo: R${litros * 6}.")
    }

    public void RealizarRevisao(){
        Console.WriteLine("Revisando freios e suspensão do Caminhão")
    }

}

public class CarroEletrico : Veiculo, IManutencao{
    public override void Abastecer(double litros){
        Console.WriteLine($"Carregando bateria com {litros}kWh");
    }

    public void RealizarRevisao(){
        Console.WriteLine("Verificando celulas da bateria e software.");
    }
}