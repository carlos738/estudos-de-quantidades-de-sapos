# este progra é apenas de uso educacional, para fins educacionais.

# Programa de Contagem de Espécies de Sapos

Este é um programa em .NET que demonstra como criar e utilizar modelos, interfaces e classes para representar espécies de sapos e calcular o número de espécies em um determinado local.

## Estrutura do Projeto

O projeto contém as seguintes partes:

1. **Modelo (Model)**
   - `Sapo.cs`: Define a classe `Sapo` com propriedades para o nome e a localização do sapo.

2. **Interface**
   - `ISapoRepository.cs`: Define a interface `ISapoRepository` com métodos para adicionar sapos e contar espécies por localização.

3. **Implementação da Interface**
   - `SapoRepository.cs`: Implementa a interface `ISapoRepository` utilizando uma lista em memória para armazenar os sapos e realizar as operações definidas na interface.

4. **Classe de Demonstração**
   - `Program.cs`: Classe principal que demonstra a adição de sapos ao repositório e a contagem de espécies em uma determinada localização.

## Como Usar

1. Clone o repositório ou baixe os arquivos do projeto.
2. Abra o projeto em seu ambiente de desenvolvimento preferido.
3. Compile e execute o projeto.

## Exemplo de Uso

O programa adiciona três sapos ao repositório:

- `Sapo Comum` na `Floresta`
- `Sapo Verde` no `Pantanal`
- `Sapo Vermelho` na `Floresta`

Em seguida, o programa calcula e exibe o número de espécies de sapos na localização "Floresta".

## Código de Exemplo

```csharp
public class Sapo
{
    public string Nome { get; set; }
    public string Localizacao { get; set; }
}

public interface ISapoRepository
{
    void AdicionarSapo(Sapo sapo);
    int ContarEspeciesPorLocalizacao(string localizacao);
}

public class SapoRepository : ISapoRepository
{
    private readonly List<Sapo> _sapos = new List<Sapo>();

    public void AdicionarSapo(Sapo sapo)
    {
        _sapos.Add(sapo);
    }

    public int ContarEspeciesPorLocalizacao(string localizacao)
    {
        return _sapos.Count(sapo => sapo.Localizacao == localizacao);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ISapoRepository sapoRepository = new SapoRepository();

        sapoRepository.AdicionarSapo(new Sapo { Nome = "Sapo Comum", Localizacao = "Floresta" });
        sapoRepository.AdicionarSapo(new Sapo { Nome = "Sapo Verde", Localizacao = "Pantanal" });
        sapoRepository.AdicionarSapo(new Sapo { Nome = "Sapo Vermelho", Localizacao = "Floresta" });

        string localizacao = "Floresta";
        int quantidadeDeEspecies = sapoRepository.ContarEspeciesPorLocalizacao(localizacao);

        Console.WriteLine($"Número de espécies de sapos em {localizacao}: {quantidadeDeEspecies}");
    }
}
