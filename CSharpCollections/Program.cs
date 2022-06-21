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
            Curso csharpColecaoe = new Curso("C# Coleções", "MArcelo Oliveira");

            csharpColecaoe.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecaoe.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecaoe.Adiciona(new Aula("Modelando com Coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecaoe.Matricula(a1);
            csharpColecaoe.Matricula(a2);
            csharpColecaoe.Matricula(a3);

            Console.WriteLine("Imprimindo os Alunos Matriculados");

            foreach (var aluno in csharpColecaoe.Alunos)
            {
                Console.WriteLine(aluno);
            }

            //Imprimir: "O aluno a1 está matriculado?"
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            //Criar um método EstaMatriculado
            Console.WriteLine(csharpColecaoe.EstaMatriculado(a1));
            //Vamos instaciar uma aluna (vanessa Tonini)
            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            //E verificar se Tonini esta matriculada
            Console.WriteLine($"Tonini esta matriculada? {csharpColecaoe.EstaMatriculado(tonini)}");
            //Mas a1 == a Tonini?
            Console.WriteLine($"a1 == a Tonini ? {a1 == tonini}");
            //O que ocorreu? a1 é equals a Tonini?
            Console.WriteLine($"a1 é equals a Tonini? {a1.Equals(tonini)}");






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
