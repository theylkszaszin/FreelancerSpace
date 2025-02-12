﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreelancerSpace.Models
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

        public virtual ICollection<ClienteModel> Clientes { get; set; }
        public virtual ICollection<FuncionariosModel> Funcionarios { get; set; }
    }
}
