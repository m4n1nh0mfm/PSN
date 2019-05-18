﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSN2018.Models
{
    public class Skill
    {
        public int id { get; set; }

        [Display(Name = "Nome da Skill:")]
        [StringLength(50, ErrorMessage = "O campo Descrição permite no máximo 50 caracteres!")]
        [Required(ErrorMessage = "Informe a Descrição")]
        public string strDsc { get; set; }
    }
}