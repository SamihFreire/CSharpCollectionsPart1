using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections", "Marcelo");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));

            //Adicionando 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 15));

            //Ordenando a lista de aulas
            //csharpColecoes.Aulas.Sort();
            
            //Copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //Ordenar a cópia
            aulasCopiadas.Sort();

            imprimir(aulasCopiadas);

            //Totalizando o tempo do curso
            Console.WriteLine(csharpColecoes.TempoTotal);

            Console.WriteLine(csharpColecoes);

            Console.ReadLine();
        }

        private static void imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
