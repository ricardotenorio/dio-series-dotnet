using System;
using Series.Classes;
using Series.Enums;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadeBase obj = new Serie(1, Genero.Acao, "Test 01", "Novo Teste", 1999);

            Console.WriteLine(obj);
        }
    }
}
