using System.Linq;
using ServicoPortaria.Domain.Entities;
using ServicoPortaria.Domain.Interfaces;
using System.Collections.Generic;

namespace ServicoPortaria.Infra.Data.Repositories
{
    public class ApartamentoRepository : RepositoryBase<Apartamento>, IApartamentoRepository
    {
        public IEnumerable<Apartamento> BuscarPorCondominio(int id)
        {
            return Db.Apartamento.Where(p => p.IdCondominio == id);
        }

        public IEnumerable<Apartamento> BuscarPorMorador(int id)
        {
            return Db.Apartamento.Where(p => p.IdMorador == id);
        }

        IEnumerable<Apartamento> IApartamentoRepository.BuscarPorBloco(string bloco)
        {
            return Db.Apartamento.Where(p => p.Bloco.Contains(bloco));
        }

        IEnumerable<Apartamento> IApartamentoRepository.BuscarPorNumero(int numero)
        {
            return Db.Apartamento.Where(p => p.Numero == numero);
        }

        IEnumerable<Apartamento> IApartamentoRepository.BuscarPorRamal(string ramal)
        {
            return Db.Apartamento.Where(p => p.Ramal.Contains(ramal));
        }
    }
}
