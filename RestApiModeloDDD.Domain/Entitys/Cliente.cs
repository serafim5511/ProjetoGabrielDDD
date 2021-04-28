using System;
using System.Collections.Generic;

namespace ProjetoGabrielDDD.Domain.Entitys
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool IsAtivo { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }


    
    }
}
