using System;
using System.Linq;
using System.Collections.Generic;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class VisitaRepository : RepositoryBase<Visita>, IVisitaRepository
    {
        public IEnumerable<Visita> BuscarPorApartamento(int id)
        {
            return Db.Visita.Where(t => t.IdApartamento == id);
        }

        public IEnumerable<Visita> BuscarPorCondominio(int id)
        {
            return Db.Visita.Where(t => t.IdCondominio == id);
        }

        public IEnumerable<Visita> BuscarPorEntrada(TimeSpan time)
        {
            return Db.Visita.Where(t => t.Chegada == time);
        }

        public IEnumerable<Visita> BuscarPorPredio(int id)
        {
            return Db.Visita.Where(t => t.IdPredio == id);
        }

        public IEnumerable<Visita> BuscarPorSaida(TimeSpan time)
        {
            return Db.Visita.Where(t => t.Saida == time);
        }

        public IEnumerable<Visita> BuscarPorVisitante(int id)
        {
            return Db.Visita.Where(t => t.IdVisitante == id);
        }
    }
}
