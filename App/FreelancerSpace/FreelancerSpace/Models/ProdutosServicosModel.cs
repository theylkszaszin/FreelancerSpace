﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerSpace.Models
{
    public class ProdutosServicosModel
    {
        [KeyAttribute]
        public int Id { get; set; }
        public int IdRamoAtividade { get; set; }
        [Required(ErrorMessage = "Nome Produto/Serviço é obrigatório")]
        [Display(Name = "Nome Produto/Serviço")]
        public string Nome { get; set; }
        [Display(Name = "Descrição")]
        [StringLength(maximumLength: 50, ErrorMessage = "Informar no máximo 100 caracteres")]
        public string Descricao { get; set; }

        public virtual RamoAtividadeModel IdRamoAtividadeNavigation { get; set; }
    }
}
