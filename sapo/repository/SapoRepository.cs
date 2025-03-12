using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sapo.Interface;
using sapo.Models;

namespace sapo.repository
{
    public class SapoRepository : ISapoRepository
    {
        private readonly List<Sapo> _sapos = new List<Sapo>();

        public void AdicionarSapo(Sapo sapo){
            _sapos.Add(sapo);
        }
        public int ContarEspeciePorLocalizacao(string localizacao){
            return _sapos.Count(sapo => sapo.Localizacao == localizacao);
        }
    }
}