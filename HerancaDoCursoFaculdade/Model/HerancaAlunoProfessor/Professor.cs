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



        private void ConsultarTurma()
        {
            Console.WriteLine("CONSULTADO");

        }

        private void LancarNota()
        {
            Console.WriteLine("LANCADO");

        }

        private void RealizarFrequencia()
        {
            Console.WriteLine("REALIZADO");
        }
    }
}
