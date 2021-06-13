using HerancaDoCursoFaculdade.Model.HerancaAlunoProfessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaDIsciplina
{
   public abstract  class DetalheCurso


    {

        public Curso CodigoCurso { get; set; }
        public Turma CodigoTurma { get; set; }
    }
}
