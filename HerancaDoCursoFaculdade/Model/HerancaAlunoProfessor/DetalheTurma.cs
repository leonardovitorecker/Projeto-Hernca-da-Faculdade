using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaAlunoProfessor
{
   public abstract class DetalheTurma
    {
        public Aluno Aluno { get; set; }
        public Professor Professor { get;set }
        public Turma CodigoTurma { get; set; }
    }
}
