using HerancaDoCursoFaculdade.Model.HerancaDIsciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaAlunoProfessor
{
   public  class Turma
    {
        public string Codigo { get; set; }
        public Curso  CodCurso { get; set; }
        

        public  void ListarTurma()
        {
            Console.WriteLine("listando a turma ");

        }

    public  void ListarAlunos()
        {
            Console.WriteLine("listando os alunos ");
        }
         }
}
