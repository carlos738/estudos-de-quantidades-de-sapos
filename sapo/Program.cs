using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sapo.Interface;
using sapo.Models;
using sapo.repository;

namespace sapo{
class Program
{
    static void Main(string[] args)
    {
        ISapoRepository sapoRepository = new SapoRepository();

        sapoRepository.AdicionarSapo(new Sapo { Nome = "Sapo Comum", Localizacao = "Floresta" });
        sapoRepository.AdicionarSapo(new Sapo { Nome = "Sapo Verde", Localizacao = "Pantanal" });
        sapoRepository.AdicionarSapo(new Sapo { Nome = "Sapo Vermelho", Localizacao = "Floresta" });

        string localizacao = "Floresta";
        int quantidadeDeEspecies = sapoRepository.ContarEspeciePorLocalizacao(localizacao);

        Console.WriteLine($"Número de espécies de sapos em {localizacao}: {quantidadeDeEspecies}");
    }
}
}
