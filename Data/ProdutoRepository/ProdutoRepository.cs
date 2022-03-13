using Business.ProductInterface;
using Data.Config;
using Data.GenericRepository;
using Microsoft.EntityFrameworkCore;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ProdutoRepository
{
    public class ProdutoRepository : GenericRepository<ProdutoViewModel>, IProduto
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public ProdutoRepository()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
