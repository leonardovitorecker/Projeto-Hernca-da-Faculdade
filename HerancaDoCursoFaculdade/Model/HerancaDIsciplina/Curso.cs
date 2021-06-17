using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaDIsciplina
{
   public  class Curso
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }


        public  void ConsultarCurso()
        {
            Console.WriteLine("CONSULTAndo o curso ");
        }

        public  void IncluirCurso()
        { 
            Console.WriteLine("incluido o curso"); 
        }
    }
}
