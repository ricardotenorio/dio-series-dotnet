using System.Collections.Generic;
using Series.Interfaces;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> _series = new List<Serie>();

        public Serie AcharPorId(int id)
        {
            return _series[id];
        }

        public void Atualizar(int id, Serie serie)
        {
            _series[id] = serie;
        }

        public void Excluir(int id)
        {
            _series[id].Excluir();
        }

        public void Inserir(Serie serie)
        {
            _series.Add(serie);
        }

        public List<Serie> Listar()
        {
            return new List<Serie>(_series);
        }

        public int ProximoId()
        {
            return _series.Count;
        }
    }
}