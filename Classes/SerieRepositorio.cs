using System.Collections.Generic;
using Series.Interfaces;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> _series = new List<Serie>();

        public Serie AcharPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Atualizar(int id, Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Inserir(Serie entidade)
        {
            throw new System.NotImplementedException();
        }

        public List<Serie> Listar()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }
    }
}