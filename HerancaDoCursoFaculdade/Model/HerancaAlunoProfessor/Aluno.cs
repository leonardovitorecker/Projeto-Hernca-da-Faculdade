
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaAlunoProfessor
{
   public  class Aluno
    {
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
       

        public void RegistrarAluno()
        {


            Console.WriteLine("registrando dados do aluno");




        }


        public  void ConsultarAluno()

           
        {


            Console.WriteLine("consultando dados do aluno"); 

        }

        public void ExcluirAluno()
        {
            Console.WriteLine("excluindo dados do aluno");
        }


        public  void AlterarAluno()

        {
            Console.WriteLine("alterando dados do aluno");


        }


    }
}
