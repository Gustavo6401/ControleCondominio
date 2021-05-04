using System;
using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;

namespace ServicoPortaria.Domain.Interfaces
{
    public interface IVisitaRepository : IRepositoryBase<Visita>
    {
        IEnumerable<Visita> BuscarPorVisitante(int id);
        IEnumerable<Visita> BuscarPorPredio(int id);
        IEnumerable<Visita> BuscarPorApartamento(int id);
        IEnumerable<Visita> BuscarPorDataChegada(DateTime date);
        IEnumerable<Visita> BuscarPorEntrada(TimeSpan time);
        IEnumerable<Visita> BuscarPorSaida(TimeSpan time);
        IEnumerable<Visita> BuscarPorDataSaida(DateTime date);
        IEnumerable<Visita> BuscarPorCondominio(int id);
    }
}
