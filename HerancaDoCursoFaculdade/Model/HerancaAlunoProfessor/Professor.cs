using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaAlunoProfessor
{
  public   class Professor
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Registro { get; set; }



        public  void ConsultarTurma()
        {
            Console.WriteLine("CONSULTAndo a turma do professor");

        }

        public  void LancarNota()
        {
            Console.WriteLine("LANCAndo as notas ");

        }

        public  void RealizarFrequencia()
        {
            Console.WriteLine("REALIZAndo frequenciais ");
        }
    }
}
