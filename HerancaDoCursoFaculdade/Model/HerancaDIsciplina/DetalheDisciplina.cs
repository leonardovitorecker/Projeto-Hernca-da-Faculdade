﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaDoCursoFaculdade.Model.HerancaDIsciplina
{
   public abstract  class DetalheDisciplina
    {
        public Curso Curso { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
