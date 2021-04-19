﻿using Repositorio.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repositorio.Repositorios
{
    public class ProdutosServicosRepository : BaseRepository<ProdutosServico>
    {
        public List<ProdutosServico> getAllProdServ()
        {
            List<ProdutosServico> list = new List<ProdutosServico>();
            using (_context = new FreelancerSpaceContext())
            {
                list = _context.ProdutosServicos.Include("IdRamoAtividadeNavigation").ToList();
            }
            return list;
        }
    }
}
