using System;
using Series.Classes;
using Series.Enums;

namespace Series
{
    class Program
    {

        static SerieRepositorio repositorio = new SerieRepositorio();

        static void Main(string[] args)
        {
            string opcaoUsuario = null;

            while (opcaoUsuario != "X")
            {
                opcaoUsuario = ObterOpcaoUsuario();

                Console.WriteLine("------------------------------------------");

                switch(opcaoUsuario){
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Entrada inválida!");
                        break;
                }
            }

        }

        private static void ListarSeries()
        {
            var series = repositorio.Listar();

            Console.WriteLine("Listar séries");

            if (series.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada");
                return;
            }

            foreach (var serie in series)
            {
                var excluido = serie.RetornarExcluido();
                Console.WriteLine($"{serie.RetornarId()} - {serie.RetornarTitulo()} {(excluido ? "*Excluído*" : "")}");
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");

            var novaSerie = CriarSerie();
            
            repositorio.Inserir(novaSerie);

        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Atualizar série");

            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serieAtualizada = CriarSerie(id);
            
            repositorio.Atualizar(id, serieAtualizada);

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Excluir série");

            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            repositorio.Excluir(id);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Visualizar série");

            Console.WriteLine("Digite o id da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = repositorio.AcharPorId(id);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario() 
        {
            Console.WriteLine();
            
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }

        private static Serie CriarSerie(int id = -1) 
        {
            if (id < 0 )
            {
                id = repositorio.ProximoId();
            }

            foreach (var genero in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{(int)genero} - {genero}");
            }

            Console.WriteLine("Digite o gênero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Título:");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Ano:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Descrição:");
            string entradaDescricao = Console.ReadLine();

            

            return new Serie(
                id: id,
                genero: (Genero) entradaGenero,
                titulo: entradaTitulo,
                descricao: entradaDescricao,
                ano: entradaAno
                );
        }

    }
}
