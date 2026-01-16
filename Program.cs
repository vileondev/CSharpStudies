// Nome, Preço, Estoque e Peso
ProdutoFisico fruta = new ProdutoFisico("Melancia", 10.50, 30, 5);
fruta.ExibirDetalhes();

public abstract class Produto{

    // posso ler o nome, mas modifica-lo só com a classe
    public string Nome {get; private set;}
    private double _preco;
    public double Preco{

        get{
            return _preco;
        }

        // value é literalmente o valor da variável, também faço uma verificação para alteralo na classe.
        set
        {
            if(value < 0.10)
            {
                _preco = 0.10;
            }
            else
            {
                _preco = value;
            }
        }
    }
    
    private int _estoque; 
    public int Estoque
    {
        get
        {
            return _estoque;
        }

        set
        {
            if(value < 0)
            {
                _estoque = 0;
            }
            else
            {
                _estoque = value;
            }
        }
    }

    // Construtor da classe, nada muito especial.
    // Se eu quiser posso adicionar um valor fixo pra uma variável e optar por mudar o valor ou usar um fixo.
    public Produto(string nome, double precoInicial, int estoqueInicial)
    {
        Nome = nome;
        Preco = precoInicial;
        Estoque = estoqueInicial;
    }

    // Virtual simboliza que é uma classe que eu posso "sobrescreve-la" depois
    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}, Preço: {Preco}, Estoque: {Estoque}");
    }

}

// Herança
// Produto Físico herda os atributos do pai (Produto)
public class ProdutoFisico : Produto
{
    // Peso é um atributo único da classe filha
    public double PesoProduto{get; set;}

    // com base eu tô falando que os atributos que estão sendo referenciados pertecem ao pai
    public ProdutoFisico(string nome, double preco, int estoque, double peso) : base(nome, preco, estoque)
    {
        PesoProduto = peso;
    }

    // Override significa que estou sobrescrevendo uma classe Virtual
    public override void ExibirDetalhes()
    {
        //Base ja ta pegando o que a minha classe virtual BASE tinha e reutilizando
        base.ExibirDetalhes();
        Console.WriteLine($"Peso: {PesoProduto}");
    }
 }
