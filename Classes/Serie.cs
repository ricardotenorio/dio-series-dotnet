using Series.Enums;

namespace Series.Classes
{
    public class Serie : EntidadeBase
    {
        
        private Genero Genero { get; set; }
        private string Titulo{ get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo,
            string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string serie = "";
            serie += $"Genero: {this.Genero}\n";
            serie += $"Título: {this.Titulo}\n";
            serie += $"Descrição: {this.Descricao}\n";
            serie += $"Ano: {this.Ano}\n";
            serie += $"Excluído: {this.Excluido}";

            return serie;
        }

        public string RetornarTitulo()
        {
            return this.Titulo;
        }

        public int RetornarId()
        {
            return this.Id;
        }

        public bool RetornarExcluido()
        {
            return this.Excluido;
        }

        public void Excluir() {
            this.Excluido = true;
        }

    }
}