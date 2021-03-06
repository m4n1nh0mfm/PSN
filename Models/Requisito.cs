﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSN2018.Models
{
    public class Requisito
    {
        public int id { get; set; }

        [Display(Name = "Descrição:")]
        [StringLength(500, ErrorMessage = "O campo Descrição permite no máximo 500 caracteres!")]
        [Required(ErrorMessage = "Informe a Descrição")]
        public string strDsc { get; set; }
    }
}