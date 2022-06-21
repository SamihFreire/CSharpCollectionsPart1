using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class Curso
    {
        private ISet<Aluno> alunos = new HashSet<Aluno>();

        public IList<Aluno> Alunos
        {
            get
            {
                return new ReadOnlyCollection<Aluno>(alunos.ToList());
            }
        }

        private IList<Aula> aulas;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();  
        }

        public void Matricula(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get{
                //int total = 0;
                //foreach (var item in aulas)
                //{
                //    total += item.Tempo;
                //}

                //Utilizando LINQ
                return aulas.Sum(aula => aula.Tempo);
            }
        }


        public override string ToString() // Override no metodo ToString para imprimir as aulas
        {
            return $"Curso:{nome} , Tempo: {TempoTotal}, Aulas: {string.Join("," , aulas)}";
        }

        public bool EstaMatriculado(Aluno aluno)
        {
            return alunos.Contains(aluno);
        }
    }
}
