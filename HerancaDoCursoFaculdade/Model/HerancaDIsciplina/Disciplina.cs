using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaDIsciplina
{
   public  class Disciplina
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }


        private void ConsultarDisciplina()
        {
            Console.WriteLine("CONSULTADO");
        }

        private void IncluirDisciplina()
        {
            Console.WriteLine("incluido");
        }
    }
}
