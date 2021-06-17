using HerancaDoCursoFaculdade.Model.HerancaAlunoProfessor;
using HerancaDoCursoFaculdade.Model.HerancaDIsciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            {
                a.Nome = "leonardo";
                a.Sexo = "MASCULINO";
                a.Matricula = "123123";
                a.DataNascimento = DateTime.Now;

                Console.WriteLine($"aluno\n" +
                    $"codigo aluno:{a.Nome} \n" +
                    $"sexo{a.Sexo } \n" +
                    $"matricula :{a.Matricula}\n" +
                    $"data de nascimento :{a.DataNascimento} "
                    );


                a.RegistrarAluno();
                a.ConsultarAluno();
                a.AlterarAluno();
                a.ExcluirAluno();
                Console.WriteLine("-------------------------");
            }


            Professor p = new Professor();
            {
                  p.Nome = "paulo";
                 p.Sexo = "masculino";
                p.Registro = "12424";

                Console.WriteLine($"professor \n" +
                    $"codigo professor:{p.Registro} \n" +
                    $"sexo{p.Sexo } \n " +
                    $"nome: {p.Nome }");



                p.ConsultarTurma();
                p.LancarNota();
                p.RealizarFrequencia();

                Console.WriteLine("-------------------------");

            }
            Curso c = new Curso();
            {
                c.Codigo = "12321";
                c.Nome = "tads";

                 Console.WriteLine($"curso \n" +
                     $"codigo curso:{c.Codigo} \n" +
                     $"nome curso{c.Nome} ");

                c.ConsultarCurso();
                c.IncluirCurso();
                Console.WriteLine("-------------------------");
            }

            Turma t = new Turma();
            {
                t.Codigo = "12";
                t.CodCurso = c;

                Console.WriteLine($"turma \n" +
                    $"codigo curso:{t.CodCurso.Codigo} \n" +
                    $"codigo turma{t.Codigo} ");

                t.ListarAlunos();
                t.ListarTurma();
                Console.WriteLine("-------------------------");
            }

            Disciplina d = new Disciplina();
            {
                d.Codigo = "13";
                  d.Nome = "banco de dados";

                   Console.WriteLine($"disciplina \n" +
                       $"codigo disciplina:{d.Codigo} \n" +
                       $" nome {d.Nome}");

                d.ConsultarDisciplina();
                d.IncluirDisciplina();
                Console.WriteLine("-------------------------");
            }

          

            DetalheDisciplina dd = new DetalheDisciplina();
            {
                dd.Curso = c;
                dd.CodDisciplina = d;

                Console.WriteLine($" DETALHEdisciplina \n" +
                    $" codigo do professor:{dd.Curso.Codigo} \n" +
                                   $"Codigo da disciplina:{dd.CodDisciplina.Codigo }");
                Console.WriteLine("-------------------------");
            }

            DetalheCurso dc = new DetalheCurso();
            {
                dc.CodigoCurso = c;
                dc.CodigoTurma = t;

                Console.WriteLine($" DETALHECURSO \n" +
                    $" codigo do professor:{dc.CodigoCurso.Codigo} \n" +
                                   $"Codigo da disciplina:{dc.CodigoTurma.Codigo }");
                Console.WriteLine("-------------------------");


            }


            DetalheTurma dt = new DetalheTurma();
            { 
            dt.Aluno = a;
            dt.Professor = p;
            dt.CodigoTurma = t;

            Console.WriteLine($"detalheturma \n" +
                $"codigo do professor:{dt.Professor.Registro } \n" +
                                   $"Codigo do aluno:{dt.Aluno.Matricula  } \n" +
                                   $"codigo da turma :{dt.CodigoTurma.Codigo }");
                Console.WriteLine("-------------------------");
            }

            Console.ReadLine();
        }
    }
}
