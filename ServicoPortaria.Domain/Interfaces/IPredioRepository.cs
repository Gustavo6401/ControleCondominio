﻿using System.Collections.Generic;
using ServicoPortaria.Domain.Enttities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IPredioRepository : IRepositoryBase<Predio> 
    {
        IEnumerable<Predio> BuscarPorNome(string nome);
        IEnumerable<Predio> BuscarPorNumero(int numero);
        IEnumerable<Predio> BuscarPorCondominio(string nome);
    }
}
