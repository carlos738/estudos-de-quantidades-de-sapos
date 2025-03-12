using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sapo.Models;

namespace sapo.Interface
{
    public interface ISapoRepository
    {
        void AdicionarSapo(Sapo sapo);
        int ContarEspeciePorLocalizacao(string locaclizacao);

        
    }
}