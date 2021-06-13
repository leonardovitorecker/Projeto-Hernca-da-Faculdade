
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
       

        private  void   RegistrarAluno()
        {
            Aluno a = new Aluno();

            a.Nome = "leonardo";
            a.Sexo = "masculino";
            a.Matricula = "1 semestre";
            a.DataNascimento = DateTime.Now;



          

        }


        public  void ConsultarAluno()

           
        {
            Console.WriteLine($"DADOS DO ALUNO: \n Nome :{a.Nome} \n" +
                           $" Sexo: {a.Sexo} \n " +
                           $" matricula :{a.Matricula} \n " +
                           $" data de nascimento :{a.DataNascimento} \n");

            Console.ReadLine();

        }

        private void ExcluirAluno()
        {
        Aluno selec
        }


        private void AlterarAluno()

        {
            RegistrarAluno();

            Aluno a1 = new Aluno() as Aluno;
                {

                a.Nome = a1.Nome;


                 }

       
        }


    }
}
