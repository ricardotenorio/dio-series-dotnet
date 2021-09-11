using Series.Enums;

namespace Series.Classes
{
    public class Serie : EntidadeBase
    {
        
        private Genero Genero { get; set; }
        private string Titulo{ get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo,
            string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            string serie = $"Genero: {Genero}\nTítulo: {Titulo}\nDescrição: {Descricao}\nAno: {Ano}";


            return serie;
        }

    }
}