using Business.GenericInterface;
using Model.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ProductInterface
{
    public interface IProduto : IGeneric<ProdutoViewModel>
    {
    }
}
