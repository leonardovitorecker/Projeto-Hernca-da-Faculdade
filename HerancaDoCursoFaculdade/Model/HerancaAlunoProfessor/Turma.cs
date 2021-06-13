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
        public Curso  Curso { get; set; }
        

        private void ListarTurma()
        {
            Console.WriteLine("listado");

        }

    private void ListarAlunos()
        {
            Console.WriteLine("listado");
        }
         }
}
