using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Natan.LojaVirtual.Dominio.Entidades;

namespace Natan.LojaVirtual.Web.Models
{
    public class ProdutosViewModel
    {

        public IEnumerable<Produto> Produtos { get; set; }

        public Paginacao Paginacao { get; set; }
    }
}