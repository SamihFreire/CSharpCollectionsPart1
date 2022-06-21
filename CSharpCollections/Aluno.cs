using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCollections
{
    public class Aluno
    {
        private string nome;
        private int nuemroMatricula;

        public Aluno(string nome, int nuemroMatricula)
        {
            this.nome = nome;
            this.nuemroMatricula = nuemroMatricula;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int NumeroMatricula
        {
            get { return nuemroMatricula; }
            set { nuemroMatricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome}, Matrícula: {nuemroMatricula}]";
        }

        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null) //Falhou a comparação
                return false;
            return this.nome.Equals(outro.nome);
        }

        public override int GetHashCode()
        {
            return this.nome.GetHashCode();
        }
    }
}
